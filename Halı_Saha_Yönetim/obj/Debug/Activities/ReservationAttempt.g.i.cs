﻿#pragma checksum "..\..\..\Activities\ReservationAttempt.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "279102FA9F595556A11B1B69CD04A866BFA259A8589225FBAD0FE7887C04BD59"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

using Halı_Saha_Yönetim.PageScreens;
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


namespace Halı_Saha_Yönetim.PageScreens {
    
    
    /// <summary>
    /// ReservationAttempt
    /// </summary>
    public partial class ReservationAttempt : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Activities\ReservationAttempt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbSaat;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Activities\ReservationAttempt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbSaha;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Activities\ReservationAttempt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox rezNot;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Activities\ReservationAttempt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveResAttempt;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Activities\ReservationAttempt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label sahaAd;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Activities\ReservationAttempt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label sahaFiyat;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Activities\ReservationAttempt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label sahaKapasite;
        
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
            System.Uri resourceLocater = new System.Uri("/Halı Saha Yönetim;component/activities/reservationattempt.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Activities\ReservationAttempt.xaml"
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
            this.cmbSaat = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.cmbSaha = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\..\Activities\ReservationAttempt.xaml"
            this.cmbSaha.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbSaha_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.rezNot = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnSaveResAttempt = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Activities\ReservationAttempt.xaml"
            this.btnSaveResAttempt.Click += new System.Windows.RoutedEventHandler(this.BtnSaveResAttempt_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 40 "..\..\..\Activities\ReservationAttempt.xaml"
            ((System.Windows.Controls.DatePicker)(target)).SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.Tarih_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.sahaAd = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.sahaFiyat = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.sahaKapasite = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

