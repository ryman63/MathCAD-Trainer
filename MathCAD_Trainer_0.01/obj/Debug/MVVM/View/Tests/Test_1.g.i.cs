﻿#pragma checksum "..\..\..\..\..\MVVM\View\Tests\Test_1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "50F54E819362464BE036CAD44202C50C1DEA30125E7095D68C15019BECE5C829"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MathCAD_Trainer_0._01.MVVM.View.Test;
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


namespace MathCAD_Trainer_0._01.MVVM.View.Test {
    
    
    /// <summary>
    /// Test_1
    /// </summary>
    public partial class Test_1 : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\..\..\MVVM\View\Tests\Test_1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border num1Border;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\MVVM\View\Tests\Test_1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox num1;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\..\MVVM\View\Tests\Test_1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border num2Border;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\..\MVVM\View\Tests\Test_1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox num2;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\..\MVVM\View\Tests\Test_1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock resultTextBlock;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\..\MVVM\View\Tests\Test_1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button checkButton;
        
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
            System.Uri resourceLocater = new System.Uri("/MathCAD_Trainer_0.01;component/mvvm/view/tests/test_1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\MVVM\View\Tests\Test_1.xaml"
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
            this.num1Border = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.num1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.num2Border = ((System.Windows.Controls.Border)(target));
            return;
            case 4:
            this.num2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.resultTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.checkButton = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\..\..\..\MVVM\View\Tests\Test_1.xaml"
            this.checkButton.Click += new System.Windows.RoutedEventHandler(this.checkButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

