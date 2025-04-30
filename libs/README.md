# Please update the version number for each merge to main, this will be the package version
```xml
csproj file
<Version>1.0.5</Version>
```
# Testing Locally with Local Library Builds

To test locally with local library builds, use the following steps:

Replace the NuGet package reference:
```xml
csproj file
   <PackageReference Include="LibDemo" Version="1.0.5"/>
  
   with

   <Reference Include="LibDemo">
     <HintPath>..\..\Path\to\Library\LibDemo.dll</HintPath>
   </Reference>
```

Make sure you replace this back to the PackageReference once the library has been updated.

