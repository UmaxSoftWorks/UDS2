using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;

namespace Umax.Classes.Compression
{
    public class TarStorer
    {
        internal class DataWriter : IArchiveDataWriter
        {
            private readonly long size;
            private long remainingBytes;
            private bool canWrite = true;
            private readonly Stream stream;

            public DataWriter(Stream data, long dataSizeInBytes)
            {
                size = dataSizeInBytes;
                remainingBytes = size;
                stream = data;
            }

            public int Write(byte[] buffer, int count)
            {
                if (remainingBytes == 0)
                {
                    canWrite = false;
                    return -1;
                }
                int bytesToWrite;
                if (remainingBytes - count < 0)
                {
                    bytesToWrite = (int)remainingBytes;
                }
                else
                {
                    bytesToWrite = count;
                }
                stream.Write(buffer, 0, bytesToWrite);
                remainingBytes -= bytesToWrite;
                return bytesToWrite;
            }

            public bool CanWrite
            {
                get
                {
                    return canWrite;
                }
            }
        }
        public interface IArchiveDataWriter
        {
            /// <summary>
            /// Write `length` bytes of data from `buffer` to corresponding archive.
            /// </summary>
            /// <param name="buffer">data storage</param>
            /// <param name="count">how many bytes to be written to the corresponding archive</param>
            int Write(byte[] buffer, int count);
            bool CanWrite { get; }
        }
        public delegate void WriteDataDelegate(IArchiveDataWriter writer);

        public interface ITarHeader
        {
            string FileName { get; set; }
            int Mode { get; set; }
            int UserId { get; set; }
            string UserName { get; set; }
            int GroupId { get; set; }
            string GroupName { get; set; }
            long SizeInBytes { get; set; }
            DateTime LastModification { get; set; }
            int HeaderSize { get; }
        }


        public class LegacyTarWriter : IDisposable
        {
            private readonly Stream outStream;
            protected byte[] buffer = new byte[1024];
            private bool isClosed;
            public bool ReadOnZero = true;

            /// <summary>
            /// Writes tar (see GNU tar) archive to a stream
            /// </summary>
            /// <param name="writeStream">stream to write archive to</param>
            public LegacyTarWriter(Stream writeStream)
            {
                outStream = writeStream;
            }

            protected virtual Stream OutStream
            {
                get { return outStream; }
            }

            #region IDisposable Members

            public void Dispose()
            {
                Close();
            }

            #endregion

            public void Write(string fileName, string newName)
            {
                using (FileStream file = File.OpenRead(fileName))
                {
                    Write(file, file.Length, newName, 61, 61, 511, File.GetLastWriteTime(file.Name));
                }
            }

            public void Write(FileStream file)
            {
                string path = Path.GetFullPath(file.Name).Replace(Path.GetPathRoot(file.Name), string.Empty);
                path = path.Replace(Path.DirectorySeparatorChar, '/');
                Write(file, file.Length, path, 61, 61, 511, File.GetLastWriteTime(file.Name));
            }

            public void Write(Stream data, long dataSizeInBytes, string name)
            {
                Write(data, dataSizeInBytes, name, 61, 61, 511, DateTime.Now);
            }

            public virtual void Write(string name, long dataSizeInBytes, int userId, int groupId, int mode, DateTime lastModificationTime, WriteDataDelegate writeDelegate)
            {
                IArchiveDataWriter writer = new DataWriter(OutStream, dataSizeInBytes);
                WriteHeader(name, lastModificationTime, dataSizeInBytes, userId, groupId, mode);
                while (writer.CanWrite)
                {
                    writeDelegate(writer);
                }
                AlignTo512(dataSizeInBytes, false);
            }

            public virtual void Write(Stream data, long dataSizeInBytes, string name, int userId, int groupId, int mode,
                                      DateTime lastModificationTime)
            {
                if (isClosed)
                    throw new Exception("Can not write to the closed writer");
                WriteHeader(name, lastModificationTime, dataSizeInBytes, userId, groupId, mode);
                WriteContent(dataSizeInBytes, data);
                AlignTo512(dataSizeInBytes, false);
            }

            protected void WriteContent(long count, Stream data)
            {
                while (count > 0 && count > buffer.Length)
                {
                    int bytesRead = data.Read(buffer, 0, buffer.Length);
                    if (bytesRead < 0)
                        throw new IOException("LegacyTarWriter unable to read from provided stream");
                    if (bytesRead == 0)
                    {
                        if (!ReadOnZero)
                            break;
                    }
                    OutStream.Write(buffer, 0, bytesRead);
                    count -= bytesRead;
                }
                if (count > 0)
                {
                    int bytesRead = data.Read(buffer, 0, (int)count);
                    if (bytesRead < 0)
                        throw new IOException("LegacyTarWriter unable to read from provided stream");
                    if (bytesRead == 0)
                    {
                        while (count > 0)
                        {
                            OutStream.WriteByte(0);
                            --count;
                        }
                    }
                    else
                        OutStream.Write(buffer, 0, bytesRead);
                }
            }

            protected virtual void WriteHeader(string name, DateTime lastModificationTime, long count, int userId, int groupId, int mode)
            {
                var header = new TarHeader
                {
                    FileName = name,
                    LastModification = lastModificationTime,
                    SizeInBytes = count,
                    UserId = userId,
                    GroupId = groupId,
                    Mode = mode
                };
                OutStream.Write(header.GetHeaderValue(), 0, header.HeaderSize);
            }


            public void AlignTo512(long size, bool acceptZero)
            {
                size = size % 512;
                if (size == 0 && !acceptZero) return;
                while (size < 512)
                {
                    OutStream.WriteByte(0);
                    size++;
                }
            }

            public virtual void Close()
            {
                if (isClosed) return;
                AlignTo512(0, true);
                AlignTo512(0, true);
                isClosed = true;
            }
        }

        internal class TarHeader : ITarHeader
        {
            private readonly byte[] buffer = new byte[512];
            private long headerChecksum;

            public TarHeader()
            {
                // Default values
                Mode = 511; // 0777 dec
                UserId = 61; // 101 dec
                GroupId = 61; // 101 dec
            }

            private string fileName;
            protected readonly DateTime TheEpoch = DateTime.Now;

            public virtual string FileName
            {
                get
                {
                    return fileName.Replace("\0", string.Empty);
                }
                set
                {
                    if (value.Length > 100)
                    {
                        throw new Exception("A file name can not be more than 100 chars long");
                    }
                    fileName = value;
                }
            }
            public int Mode { get; set; }

            public string ModeString
            {
                get { return AddChars(Convert.ToString(Mode, 8), 7, '0', true); }
            }

            public int UserId { get; set; }
            public virtual string UserName
            {
                get { return UserId.ToString(); }
                set { UserId = Int32.Parse(value); }
            }

            public string UserIdString
            {
                get { return AddChars(Convert.ToString(UserId, 8), 7, '0', true); }
            }

            public int GroupId { get; set; }
            public virtual string GroupName
            {
                get { return GroupId.ToString(); }
                set { GroupId = Int32.Parse(value); }
            }

            public string GroupIdString
            {
                get { return AddChars(Convert.ToString(GroupId, 8), 7, '0', true); }
            }

            public long SizeInBytes { get; set; }

            public string SizeString
            {
                get { return AddChars(Convert.ToString(SizeInBytes, 8), 11, '0', true); }
            }

            public DateTime LastModification { get; set; }

            public string LastModificationString
            {
                get
                {
                    return AddChars(
                        ((long)(LastModification - TheEpoch).TotalSeconds).ToString(), 11, '0',
                        true);
                }
            }

            public string HeaderChecksumString
            {
                get { return AddChars(Convert.ToString(headerChecksum, 8), 6, '0', true); }
            }


            public virtual int HeaderSize
            {
                get { return 512; }
            }

            private static string AddChars(string str, int num, char ch, bool isLeading)
            {
                int neededZeroes = num - str.Length;
                while (neededZeroes > 0)
                {
                    if (isLeading)
                        str = ch + str;
                    else
                        str = str + ch;
                    --neededZeroes;
                }
                return str;
            }

            public byte[] GetBytes()
            {
                return buffer;
            }

            public virtual bool UpdateHeaderFromBytes()
            {
                FileName = Encoding.Default.GetString(buffer, 0, 100);
                Mode = Convert.ToInt32(Encoding.ASCII.GetString(buffer, 100, 7), 8);
                UserId = Convert.ToInt32(Encoding.ASCII.GetString(buffer, 108, 7), 8);
                GroupId = Convert.ToInt32(Encoding.ASCII.GetString(buffer, 116, 7), 8);
                if ((buffer[124] & 0x80) == 0x80) // if size in binary
                {
                    long sizeBigEndian = BitConverter.ToInt64(buffer, 0x80);
                    SizeInBytes = IPAddress.NetworkToHostOrder(sizeBigEndian);
                }
                else
                {
                    SizeInBytes = Convert.ToInt64(Encoding.ASCII.GetString(buffer, 124, 11), 8);
                }
                long unixTimeStamp = Convert.ToInt64(Encoding.ASCII.GetString(buffer, 136, 11));
                LastModification = TheEpoch.AddSeconds(unixTimeStamp);

                var storedChecksum = Convert.ToInt32(Encoding.ASCII.GetString(buffer, 148, 6));
                RecalculateChecksum(buffer);
                if (storedChecksum == headerChecksum)
                {
                    return true;
                }

                RecalculateAltChecksum(buffer);
                return storedChecksum == headerChecksum;
            }

            private void RecalculateAltChecksum(byte[] buf)
            {
                Encoding.ASCII.GetBytes("        ").CopyTo(buf, 148);
                headerChecksum = 0;
                foreach (byte b in buf)
                {
                    if ((b & 0x80) == 0x80)
                    {
                        headerChecksum -= b ^ 0x80;
                    }
                    else
                    {
                        headerChecksum += b;
                    }
                }
            }

            public virtual byte[] GetHeaderValue()
            {
                // Clean old values
                int i = 0;
                while (i < 512)
                {
                    buffer[i] = 0;
                    ++i;
                }

                if (string.IsNullOrEmpty(FileName)) throw new Exception("FileName can not be empty.");
                if (FileName.Length >= 100) throw new Exception("FileName is too long. It must be less than 100 bytes.");

                // Fill header
                Encoding.Default.GetBytes(AddChars(FileName, 100, '\0', false)).CopyTo(buffer, 0);
                Encoding.ASCII.GetBytes(ModeString).CopyTo(buffer, 100);
                Encoding.ASCII.GetBytes(UserIdString).CopyTo(buffer, 108);
                Encoding.ASCII.GetBytes(GroupIdString).CopyTo(buffer, 116);
                Encoding.ASCII.GetBytes(SizeString).CopyTo(buffer, 124);
                Encoding.ASCII.GetBytes(LastModificationString).CopyTo(buffer, 136);

                RecalculateChecksum(buffer);

                // Write checksum
                Encoding.ASCII.GetBytes(HeaderChecksumString).CopyTo(buffer, 148);

                return buffer;
            }

            protected virtual void RecalculateChecksum(byte[] buf)
            {
                // Set default value for checksum. That is 8 spaces.
                Encoding.ASCII.GetBytes("        ").CopyTo(buf, 148);

                // Calculate checksum
                headerChecksum = 0;
                foreach (byte b in buf)
                {
                    headerChecksum += b;
                }
            }
        }

        /// <summary>
        /// Extract contents of a tar file represented by a stream for the TarReader constructor
        /// </summary>
        public class TarReader
        {
            private readonly byte[] dataBuffer = new byte[512];
            private readonly UsTarHeader header;
            private readonly Stream inStream;
            private long remainingBytesInFile;

            /// <summary>
            /// Constructs TarReader object to read data from `tarredData` stream
            /// </summary>
            /// <param name="tarredData">A stream to read tar archive from</param>
            public TarReader(Stream tarredData)
            {
                inStream = tarredData;
                header = new UsTarHeader();
            }

            public ITarHeader FileInfo
            {
                get { return header; }
            }

            /// <summary>
            /// Read all files from an archive to a directory. It creates some child directories to
            /// reproduce a file structure from the archive.
            /// </summary>
            /// <param name="destDirectory">The out directory.</param>
            /// 
            /// CAUTION! This method is not safe. It's not tar-bomb proof. 
            /// {see http://en.wikipedia.org/wiki/Tar_(file_format) }
            /// If you are not sure about the source of an archive you extracting,
            /// then use MoveNext and Read and handle paths like ".." and "../.." according
            /// to your business logic.
            public void ReadToEnd(string destDirectory)
            {
                while (MoveNext(false))
                {
                    string totalPath = destDirectory + Path.DirectorySeparatorChar + FileInfo.FileName;
                    string fileName = Path.GetFileName(totalPath);
                    string directory = totalPath.Remove(totalPath.Length - fileName.Length);
                    Directory.CreateDirectory(directory);
                    File.SetAttributes(directory, FileAttributes.Normal);
                    using (FileStream file = File.Create(totalPath))
                    {
                        Read(file);
                    }
                }
            }

            /// <summary>
            /// Read data from a current file to a Stream.
            /// </summary>
            /// <param name="dataDestanation">A stream to read data to</param>
            /// 
            /// <seealso cref="MoveNext"/>
            public void Read(Stream dataDestanation)
            {
                int readBytes;
                byte[] read;
                while ((readBytes = Read(out read)) != -1)
                {
                    dataDestanation.Write(read, 0, readBytes);
                }
            }

            protected int Read(out byte[] buffer)
            {
                if (remainingBytesInFile == 0)
                {
                    buffer = null;
                    return -1;
                }
                int align512 = -1;
                long toRead = remainingBytesInFile - 512;

                if (toRead > 0)
                    toRead = 512;
                else
                {
                    align512 = 512 - (int)remainingBytesInFile;
                    toRead = remainingBytesInFile;
                }


                int bytesRead = inStream.Read(dataBuffer, 0, (int)toRead);
                remainingBytesInFile -= bytesRead;

                if (inStream.CanSeek && align512 > 0)
                {
                    inStream.Seek(align512, SeekOrigin.Current);
                }
                else
                    while (align512 > 0)
                    {
                        inStream.ReadByte();
                        --align512;
                    }

                buffer = dataBuffer;
                return bytesRead;
            }

            /// <summary>
            /// Check if all bytes in buffer are zeroes
            /// </summary>
            /// <param name="buffer">buffer to check</param>
            /// <returns>true if all bytes are zeroes, otherwise false</returns>
            private static bool IsEmpty(IEnumerable<byte> buffer)
            {
                foreach (byte b in buffer)
                {
                    if (b != 0) return false;
                }
                return true;
            }

            /// <summary>
            /// Move internal pointer to a next file in archive.
            /// </summary>
            /// <param name="skipData">Should be true if you want to read a header only, otherwise false</param>
            /// <returns>false on End Of File otherwise true</returns>
            /// 
            /// Example:
            /// while(MoveNext())
            /// { 
            ///     Read(dataDestStream); 
            /// }
            /// <seealso cref="Read(Stream)"/>
            public bool MoveNext(bool skipData)
            {
                if (remainingBytesInFile > 0)
                {
                    if (!skipData)
                    {
                        throw new Exception(
                            "You are trying to change file while not all the data from the previous one was read. If you do want to skip files use skipData parameter set to true.");
                    }
                    // Skip to the end of file.
                    if (inStream.CanSeek)
                    {
                        long remainer = (remainingBytesInFile % 512);
                        inStream.Seek(remainingBytesInFile + (512 - (remainer == 0 ? 512 : remainer)), SeekOrigin.Current);
                    }
                    else
                    {
                        byte[] buffer;
                        while (Read(out buffer) != -1)
                        {
                        }
                    }
                }

                byte[] bytes = header.GetBytes();

                int headerRead = inStream.Read(bytes, 0, header.HeaderSize);
                if (headerRead < 512)
                {
                    throw new Exception("Can not read header");
                }

                if (IsEmpty(bytes))
                {
                    headerRead = inStream.Read(bytes, 0, header.HeaderSize);
                    if (headerRead == 512 && IsEmpty(bytes))
                    {
                        return false;
                    }
                    throw new Exception("Broken archive");
                }

                if (header.UpdateHeaderFromBytes())
                {
                    throw new Exception("Checksum check failed");
                }

                remainingBytesInFile = header.SizeInBytes;

                return true;
            }
        }

        public class TarWriter : LegacyTarWriter
        {
            public TarWriter(Stream writeStream)
                : base(writeStream)
            {
            }

            protected override void WriteHeader(string name, DateTime lastModificationTime, long count, int userId, int groupId, int mode)
            {
                var tarHeader = new UsTarHeader()
                {
                    FileName = name,
                    LastModification = lastModificationTime,
                    SizeInBytes = count,
                    UserId = userId,
                    UserName = Convert.ToString(userId, 8),
                    GroupId = groupId,
                    GroupName = Convert.ToString(groupId, 8),
                    Mode = mode
                };
                OutStream.Write(tarHeader.GetHeaderValue(), 0, tarHeader.HeaderSize);
            }

            protected virtual void WriteHeader(string name, DateTime lastModificationTime, long count, string userName, string groupName, int mode)
            {
                var tarHeader = new UsTarHeader()
                {
                    FileName = name,
                    LastModification = lastModificationTime,
                    SizeInBytes = count,
                    UserId = userName.GetHashCode(),
                    UserName = userName,
                    GroupId = groupName.GetHashCode(),
                    GroupName = groupName,
                    Mode = mode
                };
                OutStream.Write(tarHeader.GetHeaderValue(), 0, tarHeader.HeaderSize);
            }


            public virtual void Write(string name, long dataSizeInBytes, string userName, string groupName, int mode, DateTime lastModificationTime, WriteDataDelegate writeDelegate)
            {
                var writer = new DataWriter(OutStream, dataSizeInBytes);
                WriteHeader(name, lastModificationTime, dataSizeInBytes, userName, groupName, mode);
                while (writer.CanWrite)
                {
                    writeDelegate(writer);
                }
                AlignTo512(dataSizeInBytes, false);
            }


            public void Write(Stream data, long dataSizeInBytes, string fileName, string userId, string groupId, int mode,
                              DateTime lastModificationTime)
            {
                WriteHeader(fileName, lastModificationTime, dataSizeInBytes, userId, groupId, mode);
                WriteContent(dataSizeInBytes, data);
                AlignTo512(dataSizeInBytes, false);
            }
        }

        /// <summary>
        /// UsTar header implementation.
        /// </summary>
        internal class UsTarHeader : TarHeader
        {
            private const string magic = "ustar";
            private const string version = "  ";
            private string groupName;

            private string namePrefix = string.Empty;
            private string userName;

            public override string UserName
            {
                get { return userName.Replace("\0", string.Empty); }
                set
                {
                    if (value.Length > 32)
                    {
                        throw new Exception("user name can not be longer than 32 chars");
                    }
                    userName = value;
                }
            }

            public override string GroupName
            {
                get { return groupName.Replace("\0", string.Empty); }
                set
                {
                    if (value.Length > 32)
                    {
                        throw new Exception("group name can not be longer than 32 chars");
                    }
                    groupName = value;
                }
            }

            public override string FileName
            {
                get { return namePrefix.Replace("\0", string.Empty) + base.FileName.Replace("\0", string.Empty); }
                set
                {
                    if (value.Length > 100)
                    {
                        if (value.Length > 255)
                        {
                            throw new Exception("UsTar fileName can not be longer thatn 255 chars");
                        }
                        int position = value.Length - 100;

                        // Find first path separator in the remaining 100 chars of the file name
                        while (!IsPathSeparator(value[position]))
                        {
                            ++position;
                            if (position == value.Length)
                            {
                                break;
                            }
                        }
                        if (position == value.Length)
                            position = value.Length - 100;
                        namePrefix = value.Substring(0, position);
                        base.FileName = value.Substring(position, value.Length - position);
                    }
                    else
                    {
                        base.FileName = value;
                    }
                }
            }

            public override bool UpdateHeaderFromBytes()
            {
                byte[] bytes = GetBytes();
                UserName = Encoding.ASCII.GetString(bytes, 0x109, 32);
                GroupName = Encoding.ASCII.GetString(bytes, 0x129, 32);
                namePrefix = Encoding.ASCII.GetString(bytes, 347, 157);
                return base.UpdateHeaderFromBytes();
            }

            private static bool IsPathSeparator(char ch)
            {
                return (ch == '\\' || ch == '/' || ch == '|'); // All the path separators I ever met.
            }

            public override byte[] GetHeaderValue()
            {
                byte[] header = base.GetHeaderValue();

                Encoding.ASCII.GetBytes(magic).CopyTo(header, 0x101); // Mark header as ustar
                Encoding.ASCII.GetBytes(version).CopyTo(header, 0x106);
                Encoding.ASCII.GetBytes(UserName).CopyTo(header, 0x109);
                Encoding.ASCII.GetBytes(GroupName).CopyTo(header, 0x129);
                Encoding.ASCII.GetBytes(namePrefix).CopyTo(header, 347);

                if (SizeInBytes >= 0x1FFFFFFFF)
                {
                    byte[] bytes = BitConverter.GetBytes(IPAddress.HostToNetworkOrder(SizeInBytes));
                    SetMarker(AlignTo12(bytes)).CopyTo(header, 124);
                }

                RecalculateChecksum(header);
                Encoding.ASCII.GetBytes(HeaderChecksumString).CopyTo(header, 148);
                return header;
            }

            private static byte[] SetMarker(byte[] bytes)
            {
                bytes[0] |= 0x80;
                return bytes;
            }

            private static byte[] AlignTo12(byte[] bytes)
            {
                var retVal = new byte[12];
                bytes.CopyTo(retVal, 12 - bytes.Length);
                return retVal;
            }
        }
    }
}
