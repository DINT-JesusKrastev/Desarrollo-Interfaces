﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38DA1E865357E09F9BFF36C2A2ADC84935711F17"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using Tema2_Opacidad;


namespace Tema2_Opacidad {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image portadaUno;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image portadaDos;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image portadaTres;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Tema2-Opacidad;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.portadaUno = ((System.Windows.Controls.Image)(target));
            
            #line 19 "..\..\..\MainWindow.xaml"
            this.portadaUno.MouseEnter += new System.Windows.Input.MouseEventHandler(this.PortadaImage_MouseEnter);
            
            #line default
            #line hidden
            
            #line 19 "..\..\..\MainWindow.xaml"
            this.portadaUno.MouseLeave += new System.Windows.Input.MouseEventHandler(this.PortadaImage_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 2:
            this.portadaDos = ((System.Windows.Controls.Image)(target));
            
            #line 29 "..\..\..\MainWindow.xaml"
            this.portadaDos.MouseEnter += new System.Windows.Input.MouseEventHandler(this.PortadaImage_MouseEnter);
            
            #line default
            #line hidden
            
            #line 29 "..\..\..\MainWindow.xaml"
            this.portadaDos.MouseLeave += new System.Windows.Input.MouseEventHandler(this.PortadaImage_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 3:
            this.portadaTres = ((System.Windows.Controls.Image)(target));
            
            #line 39 "..\..\..\MainWindow.xaml"
            this.portadaTres.MouseEnter += new System.Windows.Input.MouseEventHandler(this.PortadaImage_MouseEnter);
            
            #line default
            #line hidden
            
            #line 39 "..\..\..\MainWindow.xaml"
            this.portadaTres.MouseLeave += new System.Windows.Input.MouseEventHandler(this.PortadaImage_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

