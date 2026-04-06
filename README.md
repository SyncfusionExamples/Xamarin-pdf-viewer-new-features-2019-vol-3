# Xamarin-pdf-viewer-new-features-2019-vol-3
This repository contains sample projects that demonstrate the new features and enhancements introduced in Syncfusion® PDF Viewer for Xamarin.Forms as part of the 2019 Volume 3 release. The samples included here are intended to help developers understand how to configure and use the PDF Viewer control for common real‑world requirements such as loading encrypted documents, restricting zoom levels, and displaying documents in single‑page view mode.
## Overview
The Syncfusion PDF Viewer for Xamarin.Forms provides a powerful and flexible way to display PDF documents across Android and iOS platforms using a single shared codebase. With the 2019 Volume 3 release, several usability and security‑related enhancements were added to improve the overall document viewing experience.
This repository focuses on showcasing those enhancements through simple, focused demos that can be easily integrated into existing Xamarin.Forms applications.
### Features Covered in This Repository
#### 1. Loading Encrypted PDF Documents
This sample demonstrates how to load password‑protected or encrypted PDF files using the Syncfusion PDF Viewer. Encrypted documents are commonly used to protect sensitive data, and the PDF Viewer now provides APIs that allow you to supply the required password programmatically while loading the document.
The demo includes:

Loading encrypted PDFs from local storage or streams
Providing the document password securely
Handling incorrect or missing password scenarios

This feature is useful for enterprise applications that work with confidential or secured documents.
#### 2. Setting Minimum Zoom Percentage
Another enhancement introduced in the 2019 Volume 3 release is the ability to control the minimum zoom level of the PDF document. This sample shows how to restrict zooming so that users cannot zoom out beyond a defined percentage.
The demo covers:

Setting minimum zoom factor programmatically
Ensuring better readability and consistent UI layout
Preventing excessive zoom‑out that could make content unusable

This feature is especially useful for form‑based documents and reports where readability is critical.
#### 3. Displaying PDFs in Single Page Mode
This repository also demonstrates how to configure the PDF Viewer to load documents in single‑page view mode. Instead of continuous scrolling, the viewer displays one page at a time, which can improve focus and navigation for certain types of documents.
The sample includes:

Enabling single‑page view
Navigating between pages programmatically or via gestures
Improving the reading experience for presentations and textbooks

### Prerequisites
Before running the samples, ensure that you have:

Visual Studio with Xamarin workload installed
A valid Syncfusion license
Basic knowledge of Xamarin.Forms

## Conclusion
This repository serves as a reference for developers who want to explore and implement the 2019 Volume 3 features of the Syncfusion Xamarin.Forms PDF Viewer. By using these demos, you can quickly learn how to work with encrypted documents, control zoom behavior, and customize page viewing modes to match your application requirements.
For more details, refer to the official Syncfusion [documentation](https://help.syncfusion.com/document-processing/pdf/pdf-viewer/xamarin/overview) and [API reference](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPdfViewer.XForms.html).
