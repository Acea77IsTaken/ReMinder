﻿#pragma checksum "..\..\TablonAnunciosAdmin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BD7B0339671914D10FF53507D5CB51B45B8572C83AEB340F352F5D6FE3A5B66E"
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
    /// TablonAnunciosAdmin
    /// </summary>
    public partial class TablonAnunciosAdmin : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\TablonAnunciosAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GranGrid;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\TablonAnunciosAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ListaAnunciosAdmin;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\TablonAnunciosAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Guardar;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\TablonAnunciosAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BtnCrearAnuncio;
        
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
            System.Uri resourceLocater = new System.Uri("/NoSeElNombrejaja;component/tablonanunciosadmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TablonAnunciosAdmin.xaml"
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
            this.GranGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.ListaAnunciosAdmin = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.Guardar = ((System.Windows.Controls.Border)(target));
            return;
            case 4:
            this.BtnCrearAnuncio = ((System.Windows.Controls.Border)(target));
            
            #line 50 "..\..\TablonAnunciosAdmin.xaml"
            this.BtnCrearAnuncio.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ClickCrearAnuncio);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

