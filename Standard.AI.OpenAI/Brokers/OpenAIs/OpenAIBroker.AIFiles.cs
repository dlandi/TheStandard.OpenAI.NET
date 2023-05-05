﻿// ---------------------------------------------------------------------------------- 
// Copyright (c) The Standard Organization, a coalition of the Good-Hearted Engineers 
// ----------------------------------------------------------------------------------

using System;
using System.Threading.Tasks;
using Standard.AI.OpenAI.Models.Services.Foundations.AIFiles;

namespace Standard.AI.OpenAI.Brokers.OpenAIs
{
    internal partial class OpenAIBroker
    {
        private const string FilesRelativeUrl = "v1/files";

        public async ValueTask<ExternalAIFileResponse> PostFileFormAsync(
            ExternalAIFileRequest externalFileRequest)
        {
            return await PostFormAsync<ExternalAIFileRequest, ExternalAIFileResponse>(
                relativeUrl: FilesRelativeUrl,
                externalFileRequest);
        }

        public async ValueTask<ExternalAIFileResponse> DeleteFileByIdAsync(string fileId) =>
            await DeleteAsync<ExternalAIFileResponse>(relativeUrl: $"{FilesRelativeUrl}/{fileId}");
    }
}