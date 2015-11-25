 **Want to know what is Sitecore Community Project Templates module, and why to use it?** <br/>
Check this link: [Sitecore Community Project Templates Documentation](https://github.com/varunvns/Sitecore-Community-Project-Templates/) <br/>

##What are Sitecore Community Project Templates?

Sitecore Community Project Templates, are set of projects and web solutions with multiple projects, with predefined configurations, required nuget packages and assembly references. The main highlight of the Module are the Starter Kits that we have built are the Starter Kits - one for MVC and one for WebForms Project. Currently the Starter Kits are with TDS only, considering the case on majority of devs using TDS. But moving forward we would be adding two more Starter Kits without TDS Projects, in case you want to move ahead with those.

##Why use Sitecore Community Project Templates?

All passionate developers have one thing in common, learning a new thing and then doing a small demo regarding that to understand its core concept. -- isn't it? <br/> 
And, while doing so, we create a Sitecore solution and a Visual Studio project solution. Now, for our help, **Alen Pelin** has already created SIM, which helps in setting up a Sitecore solution very quick. But still, we spend a lot of time in setting up the visual studio solution. We (Brijesh and I) thought, why not create a set of project templates (for individual projects) and starter kits (a project solution containing multiple projects) so that the time to setup things is set to minimum and a developer only concentrates on one thing -- The POC of his/her learning! <br/>

With this noble cause, started a journey of formulating the projects and what you see is a very basic first cut of the project templates. We have a future plan of upgrading these and making it very useful not just for POC stuff, but even for live projects. We dream to make it so worth of use, that for every Web project / Project solution that any Architect/Lead Developer of a project makes, he/she uses Sitecore Community Project Templates! <br/>

## How to Install the Sitecore Community Project Templates:

This is available on Visual Studio Gallery. Hence, it makes it easy to install in our Visual Studio. <br/> <br/>
Follow these steps to install Sitecore Community Project Templates in your Visual Studio. <br/>
Open your Visual Studio 2013, click on Tools Menu and Select Extensions and Updates.

![VS-Tools-Extensions-and-Updates](https://varunvns.files.wordpress.com/2015/11/vs-tools-extensions-and-updates.png)

In the left pane, Click on Online and Select Templates

![Extensions-and-updates-Left-Pane-Online-Templates](https://varunvns.files.wordpress.com/2015/11/extensions-and-updates-online-templates.png)

Next, Search for "Sitecore" and install the Sitecore Community Project Templates which looks as below

![Sitecore-Community-Project-Templates](https://varunvns.files.wordpress.com/2015/11/search-sitecore-option-3-sitecore-community-project-templates.png)

***

##How to Configure a Project Template from Sitecore Community Project Templates

We will talk about Starter Kits only.
Just a brief about Starter kit solutions, once we install Sitecore Community Project Templates from the Visual Studio Gallery and restart Visual Studio, in the File Menu, click on New Project. <br/>
In the New Project Dialog, you will be able to see, that below Visual C#, there is a new node, Sitecore Community and going in there, we see a number of projects that we can add. <br/>

![New-Project-Dialog-Sitecore-Community](https://varunvns.files.wordpress.com/2015/11/new-project-dialog.png)

Next, when we select either MVC Starterkit or WebForms StarterKit, it creates a project solution with a number of projects in there. <br/>
Now, there are a set of steps that need to be performed, to make sure that the solution is setup well and then we need to build the solution and verify that the changes are perfect. <br/> <br/>


The changes are as below: <br/>

1. Add Sitecore References: Now, this depends on whether you have a Local Nuget Server, or you generally add references to Sitecore DLLs in individual projects. If you have a Local Nuget Server to take care of the Sitecore references, and install the Nuget packages for the required versions of Sitecore. Otherwise, add a directory at the location where Solution file recides and add all required DLLs in there. Next, add a solution Folder, name it Bin-References and add all the Sitecore Assemblies to all the projects from there. <br/> 
2. Add References of all the projects in the Web Project <br/>
3. Configure the TDS projects, in the General and Build Section of its properties and connect it with your Sitecore Instance. <br/>
4. Install the Sitecore Connector again, by unchecking/checking the Install connector in TDS projects build properties. <br/>
5. Build your solution and check that the Build succeeded. <br/>

And now get started!

*** 
## Contribute to Sitecore Community Project Templates Module
Well, if you wish to contribute to this Sitecore Module, then you need to take the following steps: <br/>
1. Fork the Development Branch of the Module on Github. <br/>
2. Add the code that you wish to.<br/>
3. Create a Pull request, so that we can understand that you have added some functionality.<br/>
4. You also need to update the readme and tell us why you added it and which files were updated.<br/>
5. We will test the code on our side and will include it in the main dev branch and then the master branch if we don't find anything malicious. Also, its not like if you send a code we will add it, if it doesn't go with the concept or if it contains some malicious code, we might reject the code too. So sorry if that happens with you.

***
##Developers:

[Varun Shringarpure](https://twitter.com/varunvns) and [Brijesh Patel](https://twitter.com/brij_baroda)
 