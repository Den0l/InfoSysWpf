﻿#pragma checksum "..\..\Buy_Client_Page.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9DC3AC85A909B6CE8B39AD619C5B2D12737AA061D4C6F6063742B8B03385C2A8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Stock_Exchange_WPF;
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


namespace Stock_Exchange_WPF {
    
    
    /// <summary>
    /// Buy_Client_Page
    /// </summary>
    public partial class Buy_Client_Page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\Buy_Client_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Securities_ComboBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Buy_Client_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Quantity_TextBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Buy_Client_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock QuantityMax_TextBlock;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Buy_Client_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock QuantityError_TextBlock;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Buy_Client_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MethodPay_ComboBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Buy_Client_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DateComplit_TextBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Buy_Client_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DateComplitError_TextBlock;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Buy_Client_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AmountContr_TextBox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Buy_Client_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AmountMax_TextBlock;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Buy_Client_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AmountError_TextBlock;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Buy_Client_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Buy_Button;
        
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
            System.Uri resourceLocater = new System.Uri("/Stock_Exchange_WPF;component/buy_client_page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Buy_Client_Page.xaml"
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
            this.Securities_ComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 21 "..\..\Buy_Client_Page.xaml"
            this.Securities_ComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Securities_ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Quantity_TextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\Buy_Client_Page.xaml"
            this.Quantity_TextBox.LostFocus += new System.Windows.RoutedEventHandler(this.Quantity_TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.QuantityMax_TextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.QuantityError_TextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.MethodPay_ComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 29 "..\..\Buy_Client_Page.xaml"
            this.MethodPay_ComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MethodPay_ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DateComplit_TextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\Buy_Client_Page.xaml"
            this.DateComplit_TextBox.LostFocus += new System.Windows.RoutedEventHandler(this.DateComplit_TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DateComplitError_TextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.AmountContr_TextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\Buy_Client_Page.xaml"
            this.AmountContr_TextBox.LostFocus += new System.Windows.RoutedEventHandler(this.AmountContr_TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 9:
            this.AmountMax_TextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.AmountError_TextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.Buy_Button = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\Buy_Client_Page.xaml"
            this.Buy_Button.Click += new System.Windows.RoutedEventHandler(this.Buy_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

