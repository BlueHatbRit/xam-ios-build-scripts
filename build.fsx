#r @"FAKE.4.4.4/tools/FakeLib.dll"

open Fake
open System

let packagingRoot = "./packaging/"

Target "clean" (fun () ->
    CleanDirs [packagingRoot]
)

Target "restorePackages" (fun () ->
    // Recursively restore nuget packages
    RestorePackages()
)

Target "iosBuildAdHoc" (fun () ->
    // Build the ad-hoc IPA
    XamarinHelper.iOSBuild (fun defaults ->
        {defaults with
            ProjectPath = "ContiniousIntegrationiOS/ContiniousIntegrationiOS.csproj"
            Configuration = "Ad-Hoc"
            Platform = "iPhone"
            OutputPath = packagingRoot
            BuildIpa = true
            Target = "Build"
        })
)

// Configure dependencies
"clean"
    ==> "restorePackages"
    ==> "iosBuildAdHoc"

RunTargetOrDefault "iosBuildAdHoc"
