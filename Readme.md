<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E777)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to create a report in a separate thread

By default, the [WinForms Document Viewer](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPrinting.Preview.DocumentViewer) creates document pages in the `Application.Idle` event. Users may access document pages as soon as pages are ready. The progress bar down below the viewer indicates a document generation progress. Users can stop document generation if required.

You may wish to enable the [DocumentViewer.UseAsyncDocumentCreation](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPrinting.Control.PrintControl.UseAsyncDocumentCreation) option and enhance user experience while previewing, exporting, and printing reports. For more information, refer to the following article: [How to create a report in a separate thread](https://supportcenter.devexpress.com/ticket/details/a2359/how-to-create-a-report-in-a-separate-thread).

