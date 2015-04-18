/*
 * Copyright � 2005, Mathew Hall
 * All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without modification, 
 * are permitted provided that the following conditions are met:
 *
 *    - Redistributions of source code must retain the above copyright notice, 
 *      this list of conditions and the following disclaimer.
 * 
 *    - Redistributions in binary form must reproduce the above copyright notice, 
 *      this list of conditions and the following disclaimer in the documentation 
 *      and/or other materials provided with the distribution.
 *
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
 * ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
 * IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
 * INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
 * NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, 
 * OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
 * WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
 * ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY 
 * OF SUCH DAMAGE.
 */


using System;
using System.ComponentModel;
using System.Drawing;


namespace Umax.UI.XPTable.Models
{
	/// <summary>
	/// Stores visual appearance related properties for a Row
	/// </summary>
	public class RowStyle
	{
		#region Class Data

		/// <summary>
		/// The background color of the Row
		/// </summary>
		private Color backColor;

		/// <summary>
		/// The foreground color of the Row
		/// </summary>
		private Color foreColor;

		/// <summary>
		/// The font used to draw the text in the Row
		/// </summary>
		private Font font;

		/// <summary>
		/// The alignment of the text in the Row
		/// </summary>
		private RowAlignment alignment;

		#endregion


		#region Constructor

		/// <summary>
		/// Initializes a new instance of the RowStyle class with default settings
		/// </summary>
		public RowStyle()
		{
			this.backColor = Color.Empty;
			this.foreColor = Color.Empty;
			this.font = null;
			this.alignment = RowAlignment.Center;
		}

		#endregion


		#region Properties

		/// <summary>
		/// Gets or sets the Font used by the Row
		/// </summary>
		[Category("Appearance"),
		Description("The font used to display text in the row")]
		public Font Font
		{
			get
			{
				return this.font;
			}

			set
			{
				this.font = value;
			}
		}


		/// <summary>
		/// Gets or sets the background color for the Row
		/// </summary>
		[Category("Appearance"),
		Description("The background color used to display text and graphics in the row")]
		public Color BackColor
		{
			get
			{
				return this.backColor;
			}

			set
			{
				this.backColor = value;
			}
		}


		/// <summary>
		/// Gets or sets the foreground color for the Row
		/// </summary>
		[Category("Appearance"),
		Description("The foreground color used to display text and graphics in the row")]
		public Color ForeColor
		{
			get
			{
				return this.foreColor;
			}

			set
			{
				this.foreColor = value;
			}
		}


		/// <summary>
		/// Gets or sets the vertical alignment of the text displayed in the Row
		/// </summary>
		[Category("Appearance"),
		DefaultValue(RowAlignment.Center),
		Description("The vertical alignment of the objects displayed in the row")]
		public RowAlignment Alignment
		{
			get
			{
				return this.alignment;
			}

			set
			{
				this.alignment = value;
			}
		}

		#endregion
	}
}
