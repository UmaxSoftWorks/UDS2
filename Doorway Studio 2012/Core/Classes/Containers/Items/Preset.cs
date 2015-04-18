using System;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Tasks;

namespace Core.Classes.Containers.Items
{
    public class Preset : IPreset
    {
        #region Information
        public int ID { get; set; }
        public string Name { get; set; }
        public string Path { get; protected set; }
        #endregion

        /// <summary>
        /// Executor
        /// </summary>
        public ITaskExecutor Executor { get; set; }

        public Preset()
        {
        }

        public Preset(string PresetPath)
            : this()
        {
            this.Load(PresetPath);
        }

        protected void Load(string PresetPath)
        {
        }
        public void Save(string PresetPath)
        {
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        #region IDisposable
        public void Dispose()
        {
        }
        #endregion
    }
}
