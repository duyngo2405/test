﻿#pragma checksum "..\..\BaoCao.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C6DFF21C428377A789591CFCF92FFC33444083709AADF873CDFA0FDFD3224888"
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
    /// BaoCao
    /// </summary>
    public partial class BaoCao : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\BaoCao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdbGiangVien;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\BaoCao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdbMon;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\BaoCao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnXuatBaoCao;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\BaoCao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbGiangVien;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\BaoCao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbMonHoc;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\BaoCao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbDauRot;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\BaoCao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem cbiDau;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\BaoCao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem cbiRot;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\BaoCao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridDanhSachSV;
        
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
            System.Uri resourceLocater = new System.Uri("/ThucHanhKiemThuPhanMem;component/baocao.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BaoCao.xaml"
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
            this.rdbGiangVien = ((System.Windows.Controls.RadioButton)(target));
            
            #line 22 "..\..\BaoCao.xaml"
            this.rdbGiangVien.Checked += new System.Windows.RoutedEventHandler(this.rdbGiangVien_Checked);
            
            #line default
            #line hidden
            
            #line 22 "..\..\BaoCao.xaml"
            this.rdbGiangVien.Unchecked += new System.Windows.RoutedEventHandler(this.rdbGiangVien_Unchecked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.rdbMon = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 3:
            this.btnXuatBaoCao = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\BaoCao.xaml"
            this.btnXuatBaoCao.Click += new System.Windows.RoutedEventHandler(this.btnXuatBaoCao_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbGiangVien = ((System.Windows.Controls.ComboBox)(target));
            
            #line 26 "..\..\BaoCao.xaml"
            this.cbGiangVien.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbGiangVien_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cbMonHoc = ((System.Windows.Controls.ComboBox)(target));
            
            #line 27 "..\..\BaoCao.xaml"
            this.cbMonHoc.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbMonHoc_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cbDauRot = ((System.Windows.Controls.ComboBox)(target));
            
            #line 28 "..\..\BaoCao.xaml"
            this.cbDauRot.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbDauRot_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cbiDau = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 8:
            this.cbiRot = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 9:
            this.dataGridDanhSachSV = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

