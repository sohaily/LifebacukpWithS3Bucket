using LifeBackup.Core.Communication.Bucket;
using LifeBackup.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeBackup.Api.Controllers
{
    [Route("api/bucket")]
    [ApiController]
    public class BucketController : ControllerBase
    {
        private readonly IBucketRepository _bucketRepository;
        public BucketController(IBucketRepository bucketRepository)
        {
            _bucketRepository = bucketRepository;
        }
        [HttpPost] 
        public async Task<ActionResult<CreateBucketResponse>> CreateS3Bucket(string bucketName)
        {
           // bucketName = "plularsightss3bucket";
            var bucketExist = await _bucketRepository.DoesS3BucketExist(bucketName);
            if (bucketExist)return BadRequest("S3 bucket already exist");
            var result = await _bucketRepository.CreateBucket(bucketName);
            if (result == null) return BadRequest();
            return Ok(result);
        }
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<ListS3BucketResponse>>> ListS3Bucket()
        {
            var result = await _bucketRepository.ListBuckets();
            if (result == null) return NotFound();
            return Ok(result);
        }
        [HttpDelete]
        [Route("list")]
        public async Task<IActionResult> DeleteS3Bucket(string bucketName)
        {
            await _bucketRepository.DeleteBucket(bucketName);
            return Ok();
        }
    }
}
