﻿#pragma checksum "..\..\NhapSV.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6355E8A045BD41E30F182F4188D0F4A8E1FF08C59B6A8179315E9433519A83EA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using ThucHanhKiemThuPhanMem;


namespace ThucHanhKiemThuPhanMem {
    
    
    /// <summary>
    /// NhapSV
    /// </summary>
    public partial class NhapSV : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\NhapSV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtHoTen;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\NhapSV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker txtNgaySinh;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\NhapSV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton txtNam;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\NhapSV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTHPT;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\NhapSV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox txtNganh;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\NhapSV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDiemChuan;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\NhapSV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDiemThi;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ThucHanhKiemThuPhanMem;component/nhapsv.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NhapSV.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtHoTen = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtNgaySinh = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.txtNam = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.txtTHPT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtNganh = ((System.Windows.Controls.ComboBox)(target));
            
            #line 55 "..\..\NhapSV.xaml"
            this.txtNganh.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TxtNganh_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtDiemChuan = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtDiemThi = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 60 "..\..\NhapSV.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

