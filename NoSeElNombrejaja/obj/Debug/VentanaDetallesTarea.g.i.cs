﻿#pragma checksum "..\..\VentanaDetallesTarea.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "034CDD4A35686C3F8B3065A8156A821EDBB8E4FA6435FEE90B4604DC634530A8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using NoSeElNombrejaja;
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


namespace NoSeElNombrejaja {
    
    
    /// <summary>
    /// VentanaDetallesTarea
    /// </summary>
    public partial class VentanaDetallesTarea : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\VentanaDetallesTarea.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TbTitulo;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\VentanaDetallesTarea.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TbAdmin;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\VentanaDetallesTarea.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock FechaEntrega;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\VentanaDetallesTarea.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TbDetalles;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\VentanaDetallesTarea.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Guardar;
        
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
            System.Uri resourceLocater = new System.Uri("/NoSeElNombrejaja;component/ventanadetallestarea.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\VentanaDetallesTarea.xaml"
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
            this.TbTitulo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.TbAdmin = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.FechaEntrega = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.TbDetalles = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.Guardar = ((System.Windows.Controls.Border)(target));
            
            #line 42 "..\..\VentanaDetallesTarea.xaml"
            this.Guardar.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.BtnEntregar);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

