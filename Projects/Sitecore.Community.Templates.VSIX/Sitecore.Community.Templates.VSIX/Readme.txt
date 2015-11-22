Things to do once we create a new Project using this:

1. Add a solution Folder, name it Bin-References and add all the Sitecore Assemblies to it. Or if you have your local Nuget Server configured for the Sitecore Assemblies, install the required Sitecore Assembly related nuget packages.
2. If you have added assemblies to your project, add references to all your Projects in the Starter Kit solution. In the later case, you can skip this step.
3. Add References of all the projects in the Web Project
4. Configure the TDS projects, in the General and Build Section of its properties and connect it with your Sitecore Instance.
5. Build your solution and check that the Build succeeded.


And now get started!