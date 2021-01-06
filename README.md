# Legerity custom control sample project

This repo contains a sample UWP application with a custom control and an NUnit test project that demonstrates the API usage for writing UI tests with Appium and creating custom control wrappers with the [Legerity](https://github.com/MADE-Apps/legerity) framework.

> **Note:** This sample project takes advantage of the [page-object pattern](https://www.jamescroft.co.uk/implementing-the-page-object-pattern-in-ui-tests/), a best practice for writing UI tests. 

## Universal Windows Platform development

This sample requires Visual Studio and the Windows 10 SDKs. 

You can build the solution using Visual Studio with the following workloads installed:

- .NET desktop development
- .NET Core cross-platform development
- Universal Windows Platform development

You can download a community edition of Visual Studio for free to get started with this project.

- [Download Visual Studio](https://developer.microsoft.com/en-us/windows/downloads/)

## Using the sample

There are two projects in this repo; the UWP application with a custom control, and a UI test project. 

The UWP application showcases how you may have created custom controls in your own UWP applications today. The `MyCustomControl` element is a simple button with a flyout containing content. This control was built to showcase some of the complexities in UI testing where by some elements of your control are not rendered in the automation tree at a different location, i.e. the popups.

Within the UI test project, you will find the equivalent Legerity Windows element control wrapper, `MyCustomControl`. This is designed to show you how you can take advantage of providing reusability of components within your UI tests and simplifying how you write your tests with human readable actions such as `OpenFlyout`. 

Before running any of the projects, you will need to ensure you have the [Windows Application Driver](https://github.com/microsoft/WinAppDriver) installed on your Windows machine. This is required to run the UI automation.

In order to run the UI tests, you will first need to deploy the UWP sample application to your Windows machine. Once deployed, you can run the UI tests from the Unit Test Explorer within Visual Studio. Using the Legerity framework, the UI tests will automatically launch the Windows Application Driver and begin running the tests.

## Contributions

If you find any issues with this sample application, please feel free to log issues and contribute back fixes. 

If you are having issues with building your own custom control element wrappers with the Legerity framework, please log those issues and fixes on the [Legerity repo](https://github.com/MADE-Apps/legerity).