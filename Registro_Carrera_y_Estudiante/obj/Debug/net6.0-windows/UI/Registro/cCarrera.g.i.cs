﻿#pragma checksum "..\..\..\..\..\UI\Registro\cCarrera.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E113132E1D72B01B2874EE2D256BC301F0BE4541"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Registro_Carrera_y_Estudiante.UI.Registro;
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


namespace Registro_Carrera_y_Estudiante.UI.Registro {
    
    
    /// <summary>
    /// cCarrera
    /// </summary>
    public partial class cCarrera : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\..\UI\Registro\cCarrera.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox carreraidtext;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\UI\Registro\cCarrera.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox nombrestext;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\UI\Registro\cCarrera.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button guardar;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\UI\Registro\cCarrera.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button eliminar;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\UI\Registro\cCarrera.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editar;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\UI\Registro\cCarrera.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Ventanaconsultar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Registro_Carrera_y_Estudiante;V1.0.0.0;component/ui/registro/ccarrera.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\Registro\cCarrera.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.carreraidtext = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.nombrestext = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.guardar = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\..\UI\Registro\cCarrera.xaml"
            this.guardar.Click += new System.Windows.RoutedEventHandler(this.guardar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.eliminar = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\..\UI\Registro\cCarrera.xaml"
            this.eliminar.Click += new System.Windows.RoutedEventHandler(this.eliminar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.editar = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\..\UI\Registro\cCarrera.xaml"
            this.editar.Click += new System.Windows.RoutedEventHandler(this.editar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Ventanaconsultar = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

