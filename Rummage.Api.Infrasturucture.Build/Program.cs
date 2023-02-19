//=================================================
// Copyright (c) Coalition of Good-Hearted Engineers 
// Free To Use Comfort and Pease
//==================================================

using ADotNet.Clients;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets.Tasks;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets.Tasks.SetupDotNetTaskV1s;

var githubPipline = new GithubPipeline
{
    Name = "Runname",

    OnEvents = new Events
    {
        PullRequest = new PullRequestEvent
        {
            Branches = new string[] { "Master" }
        },

        Push = new PushEvent
        {
            Branches = new string[] { "Master" }
        }
    },

    Jobs = new Jobs
    {
        Build = new BuildJob
        {
            RunsOn = BuildMachines.Windows2022,

            Steps = new List<GithubTask>
            {
                     new CheckoutTaskV2
                     {
                         Name = "Checking out code"
                     },

                     new SetupDotNetTaskV1
                     {
                         Name = "Sting up .Net",

                          TargetDotNetVersion = new TargetDotNetVersion
                          {
                               DotNetVersion = "6.0.406"
                          }
                     },

                     new RestoreTask
                     {
                         Name = "Restoring Nuget Paskages"
                     },

                     new DotNetBuildTask
                     {
                          Name = "Building  Project"
                     },

                     new TestTask
                     {
                          Name = "Running Tests"
                     }
            }
        }
    }
};

var client = new ADotNetClient();

client.SerializeAndWriteToFile(
    adoPipeline: githubPipline,
    path: "../../../../.github/workflows/dotnet.yml");