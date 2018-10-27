// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Details about the execution of a <see cref="CloudJob.JobReleaseTask">Job Release task</see> on a compute node.
    /// </summary>
    public partial class JobReleaseTaskExecutionInformation : IPropertyMetadata
    {
        #region Constructors

        internal JobReleaseTaskExecutionInformation(Models.JobReleaseTaskExecutionInformation protocolObject)
        {
            this.ContainerInformation = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.ContainerInfo, o => new TaskContainerExecutionInformation(o).Freeze());
            this.EndTime = protocolObject.EndTime;
            this.ExitCode = protocolObject.ExitCode;
            this.FailureInformation = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.FailureInfo, o => new TaskFailureInformation(o).Freeze());
            this.Result = UtilitiesInternal.MapNullableEnum<Models.TaskExecutionResult, Common.TaskExecutionResult>(protocolObject.Result);
            this.StartTime = protocolObject.StartTime;
            this.State = UtilitiesInternal.MapEnum<Models.JobReleaseTaskState, Common.JobReleaseTaskState>(protocolObject.State);
            this.TaskRootDirectory = protocolObject.TaskRootDirectory;
            this.TaskRootDirectoryUrl = protocolObject.TaskRootDirectoryUrl;
        }

        #endregion Constructors

        #region JobReleaseTaskExecutionInformation

        /// <summary>
        /// Gets information about the container under which the task is executing.
        /// </summary>
        /// <remarks>
        /// This property is set only if the task runs in a container context.
        /// </remarks>
        public TaskContainerExecutionInformation ContainerInformation { get; }

        /// <summary>
        /// Gets the time at which the task completed.
        /// </summary>
        /// <remarks>
        /// This property is only returned if the task is in the <see cref="Common.JobReleaseTaskState.Completed"/> state.
        /// </remarks>
        public DateTime? EndTime { get; }

        /// <summary>
        /// Gets the exit code of the program specified on the task command line.
        /// </summary>
        /// <remarks>
        /// This property is only returned if the task is in the <see cref="Common.JobReleaseTaskState.Completed"/> state. 
        /// The exit code for a process reflects the specific convention implemented by the application developer for that 
        /// process. If you use the exit code value to make decisions in your code, be sure that you know the exit code convention 
        /// used by the application process. Note that the exit code may also be generated by the compute node operating 
        /// system, such as when a process is forcibly terminated.
        /// </remarks>
        public int? ExitCode { get; }

        /// <summary>
        /// Gets information describing the task failure, if any.
        /// </summary>
        /// <remarks>
        /// This property is set only if the task is in the <see cref="Common.JobReleaseTaskState.Completed"/> state and 
        /// encountered a failure.
        /// </remarks>
        public TaskFailureInformation FailureInformation { get; }

        /// <summary>
        /// Gets the result of the task execution.
        /// </summary>
        /// <remarks>
        /// If the value is <see cref="Common.TaskExecutionResult.Failure" />, then the details of the failure can be found 
        /// in the <see cref="FailureInformation" /> property.
        /// </remarks>
        public Common.TaskExecutionResult? Result { get; }

        /// <summary>
        /// Gets the time at which the task started running. Note that every time the task is restarted, this value is updated.
        /// </summary>
        public DateTime StartTime { get; }

        /// <summary>
        /// Gets the current state of the task.
        /// </summary>
        /// <remarks>
        /// Running means the task is currently running. Completed means the task has completed. The Completed state includes 
        /// the case where the task exits successfully with exit code 0 and the cases where the system fails to start the 
        /// task process due to scheduling errors or the retry limit has reached after numerous task failures. 
        /// </remarks>
        public Common.JobReleaseTaskState State { get; }

        /// <summary>
        /// Gets the root directory of the Job Release task on the compute node. You can use this path to retrieve files 
        /// created by the task, such as log files.
        /// </summary>
        public string TaskRootDirectory { get; }

        /// <summary>
        /// Gets the URL to the root directory of the Job Release task on the compute node.
        /// </summary>
        public string TaskRootDirectoryUrl { get; }

        #endregion // JobReleaseTaskExecutionInformation

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata
    }
}