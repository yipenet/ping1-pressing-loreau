﻿#pragma checksum "..\..\..\..\..\Views\UserControl\UCReception\IdentificationClient.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "071715F9454F15E5C42AC2D85DC3643C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18444
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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


namespace ProjetLoreau {
    
    
    /// <summary>
    /// IdentificationClient
    /// </summary>
    public partial class IdentificationClient : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\..\..\Views\UserControl\UCReception\IdentificationClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel dp;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\..\Views\UserControl\UCReception\IdentificationClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_identificationClient_nom;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\Views\UserControl\UCReception\IdentificationClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_identificationClient_prenom;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\..\Views\UserControl\UCReception\IdentificationClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_identificationClient_portable;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\..\Views\UserControl\UCReception\IdentificationClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_identificationClient_adresse;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\..\Views\UserControl\UCReception\IdentificationClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_identificationClient_date_naissance;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\..\Views\UserControl\UCReception\IdentificationClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_identClient_nouveau_client;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\..\Views\UserControl\UCReception\IdentificationClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagridClient;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjetLoreau;component/views/usercontrol/ucreception/identificationclient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\UserControl\UCReception\IdentificationClient.xaml"
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
            this.dp = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 2:
            this.txb_identificationClient_nom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txb_identificationClient_prenom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txb_identificationClient_portable = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txb_identificationClient_adresse = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txb_identificationClient_date_naissance = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btn_identClient_nouveau_client = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\..\..\Views\UserControl\UCReception\IdentificationClient.xaml"
            this.btn_identClient_nouveau_client.Click += new System.Windows.RoutedEventHandler(this.btn_identClient_nouveau_client_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.datagridClient = ((System.Windows.Controls.DataGrid)(target));
            
            #line 79 "..\..\..\..\..\Views\UserControl\UCReception\IdentificationClient.xaml"
            this.datagridClient.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.datagridClient_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

