﻿#region License and Copyright
/*
 
Copyright (c) Guifreaks - Jacob Mesu
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:
    * Redistributions of source code must retain the above copyright
      notice, this list of conditions and the following disclaimer.
    * Redistributions in binary form must reproduce the above copyright
      notice, this list of conditions and the following disclaimer in the
      documentation and/or other materials provided with the distribution.
    * Neither the name of the Guifreaks nor the
      names of its contributors may be used to endorse or promote products
      derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL <COPYRIGHT HOLDER> BE LIABLE FOR ANY
DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

*/
#endregion

using System.ComponentModel;
using System.Windows.Forms;

namespace NaviSuite.Common.UserControls
{
    /// <summary>
    /// Represents a control with customizable drawing and layout styles
    /// </summary>
    [ToolboxItem(false)]
    public partial class NaviControl : ContainerControl
    {
        #region Designer Code
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }

        #endregion
        #endregion

        // fields
        bool useAnimations;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the NaviControl
        /// </summary>
        public NaviControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the NaviControl
        /// </summary>
        /// <param name="container">The parent container</param>
        public NaviControl(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Defines whether animations should be used
        /// </summary>
        [DefaultValue(false)]
        public bool UseAnimations
        {
            get { return useAnimations; }
            set { useAnimations = value; }
        }

        #endregion

    }
}