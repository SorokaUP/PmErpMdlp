using System;
using PMMarkingUI.Classes;
using ProfitMed.DataContract;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PMMarkingUI.Delegats
{
    public delegate void DelegateAddPage(Control View);
    public delegate void DelegateGetDocFilterDb(DocFilterDb filter);
    public delegate void DelegateGetGtdFilter(InvoiceFilter filter);
    public delegate void DelegateGetDocFilterDbAgency(DocFilterDbAgency filter);
    public delegate void DelegateGetDocFilterTWDb(DocFilterTWDb filter);
    public delegate void DelegateGetDocFilter(DocFilters filter);
    public delegate void DelegateGetGtinFilter(MedProductsFilter filter);
    public delegate void DelegateGetDialogResult(DialogResult res);
    public delegate void DelegateCloseFilterRuntime();
    public delegate void DelegateGetGridFilter(List<string> text);
    public delegate void DelegateLogAdd(string s, bool isNeedNewLine = true);
    public delegate void DelegateVoidString(string s);
    public delegate void DelegateVoidStringString(string s1, string s2);

    //------------------------------------------------------------------------

    public delegate void DelegateVoid();
    public delegate void OnWorkIsDoneHandler(object sender, EventArgs e); // Делегат для события окна.
}