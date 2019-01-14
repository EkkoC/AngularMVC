using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Webangular.Models;
using Webangular.SQLConnection;

namespace Webangular.Controllers
{
    public class ValuesController : ApiController
    {
        private SQLConn _ConnectionFactory;
        //public ValuesController()
        //{
        //    _ConnectionFactory = new SQLConn();
        //}
        // GET api/NscTube_Report
        /// 取得此住民管路移除監測資料
        [HttpGet]
        public IEnumerable<Test> Get()
        {
            _ConnectionFactory = new SQLConn();
            IEnumerable<Test> nsctube = new List<Test>();

            using (var cn = _ConnectionFactory.CreateConnection())
            {
                string sql = " select T6091F08 from DTB6091 where T6091F08='8937' ";
                nsctube = cn.Query<Test>(sql).ToList();

            }
            return nsctube;

        }
        // GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}