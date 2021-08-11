﻿using LifeBackup.Core.Communication.Bucket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeBackup.Core.Interfaces
{
    public interface IBucketRepository
    {
        Task<bool> DoesS3BucketExist(string bucketName);
        Task<CreateBucketResponse> CreateBucket(string bucketName);
        Task<IEnumerable<ListS3BucketResponse>> ListBuckets();
        Task DeleteBucket(string bucketName);
    }
}
