using Microsoft.AspNetCore.Mvc;

namespace MissionsData.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MissionsController : ControllerBase
    {
        private static int _id = 0;
        private static readonly List<MissionsData.Models.MissionModel>
            AllMissions = new List<Models.MissionModel>();
        


        [HttpGet]
        public List<MissionsData.Models.MissionModel> GetAllMissions()
        {
            return AllMissions;
        }

        [HttpPost]
        public void AddMission(MissionsData.Models.MissionModel missionModel)
        {
            missionModel.RecordKey = _id++;
            AllMissions.Add(missionModel);
        }

        [HttpDelete]
        public void DeleteMission(int recordKey)
        {
           var mission = AllMissions.FirstOrDefault(y => y.RecordKey== recordKey);
            if (mission != null)
            {
                AllMissions.Remove(mission);
            }
        }

        [HttpPut]
        public void UpdateMission(int recordKey, MissionsData.Models.MissionModel newMission)
        {
            var mission = AllMissions.FirstOrDefault(y => y.RecordKey == recordKey);
            if(mission != null)
            {
                mission.MissionName = newMission.MissionName;
            }
        }
    }
}