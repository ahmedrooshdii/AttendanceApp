using Attendance.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Attendance.Infrastructure.DataSeed
{
    public static class AttendanceDbContextSeed
    {
        public static async Task SeedAsync(AttendanceDbContext _dbContext)
        {

            if (_dbContext.Roles.Count() == 0)
            {
            //    var rolesData = File.ReadAllText("roles.json");
                var roles = JsonSerializer.Deserialize<List<Role>>("[\r\n  {\r\n    \"RoleName\": \"Admin\"\r\n  },\r\n  {\r\n    \"RoleName\": \"Teacher\"\r\n  },\r\n  {\r\n    \"RoleName\": \"Student\"\r\n  }\r\n]\r\n");

                if (roles?.Count() > 0)
                {
                    await _dbContext.Set<Role>().AddRangeAsync(roles);
                    await _dbContext.SaveChangesAsync();
                }
            }
            if (_dbContext.Classes.Count() == 0)
            {
               // var classesData = File.ReadAllText("classes.json");
                var classes = JsonSerializer.Deserialize<List<Class>>("[\r\n  {\r\n    \"ClassName\": \"Class 1\"\r\n  },\r\n  {\r\n    \"ClassName\": \"Class 2\"\r\n  },\r\n  {\r\n    \"ClassName\": \"Class 3\"\r\n  }\r\n]");

                if (classes?.Count() > 0)
                {
                    await _dbContext.Set<Class>().AddRangeAsync(classes);
                    await _dbContext.SaveChangesAsync();
                }
            }
            if (_dbContext.Users.Count() == 0)
            {
              //  var usersData = File.ReadAllText("/DataSeed/classes.json");
                var users = JsonSerializer.Deserialize<List<User>>("[\r\n  {\r\n    \"UserName\": \"admin\",\r\n    \"Password\": \"jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=\",\r\n    \"RoleId\": 1\r\n  },\r\n  {\r\n    \"UserName\": \"teacher\",\r\n    \"Password\": \"jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=\",\r\n    \"RoleId\": 2\r\n  },\r\n  {\r\n    \"UserName\": \"student1\",\r\n    \"Password\": \"jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=\",\r\n    \"RoleId\": 3\r\n  },\r\n  {\r\n    \"UserName\": \"student2\",\r\n    \"Password\": \"jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=\",\r\n    \"RoleId\": 3\r\n  },\r\n  {\r\n    \"UserName\": \"student3\",\r\n    \"Password\": \"jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=\",\r\n    \"RoleId\": 3\r\n  }\r\n]");

                if (users?.Count() > 0)
                {
                    await _dbContext.Set<User>().AddRangeAsync(users);
                    await _dbContext.SaveChangesAsync();
                }
            }
            if (_dbContext.Students.Count() == 0)
            {
                //var studentsData = File.ReadAllText("/DataSeed/students.json");
                var students = JsonSerializer.Deserialize<List<Student>>("[\r\n  {\r\n    \"StudentName\": \"Student 1\",\r\n    \"UserId\": 3,\r\n    \"ClassId\": 1\r\n  },\r\n  {\r\n    \"StudentName\": \"Student 2\",\r\n    \"UserId\": 4,\r\n    \"ClassId\": 2\r\n  },\r\n  {\r\n    \"StudentName\": \"Student 3\",\r\n    \"UserId\": 5,\r\n    \"ClassId\": 3\r\n  }\r\n]");

                if (students?.Count() > 0)
                {
                    await _dbContext.Set<Student>().AddRangeAsync(students);
                    await _dbContext.SaveChangesAsync();
                }
            }
            if (_dbContext.Teachers.Count() == 0)
            {
                //var teachersData = File.ReadAllText("/DataSeed/teachers.json");
                var teachers = JsonSerializer.Deserialize<List<Teacher>>("[\r\n  {\r\n    \"TeacherName\": \"Teacher 1\",\r\n    \"UserId\": 2\r\n  }\r\n]");

                if (teachers?.Count() > 0)
                {
                    await _dbContext.Set<Teacher>().AddRangeAsync(teachers);
                    await _dbContext.SaveChangesAsync();
                }
            }
            if (_dbContext.TeacherClasses.Count() == 0)
            {
                //var teachersData = File.ReadAllText("/DataSeed/teachers.json");
                var teachers = JsonSerializer.Deserialize<List<TeacherClass>>("[\r\n    {\r\n        \"TeacherId\": 1,\r\n        \"ClassId\": 1\r\n    }\r\n  \r\n]");
                if (teachers?.Count() > 0)
                {
                    await _dbContext.Set<TeacherClass>().AddRangeAsync(teachers);
                    await _dbContext.SaveChangesAsync();
                }
            }
            if (_dbContext.Preferences.Count() == 0)
            {
                //    var rolesData = File.ReadAllText("roles.json");
                var preferences = JsonSerializer.Deserialize<List<Preference>>("[\r\n  {\r\n    \"Language\": \"English\",\r\n    \"DateFormat\": \"dd/MM/yyyy\",\r\n    \"Theme\": \"Light\"\r\n  }\r\n]");

                if (preferences?.Count() > 0)
                {
                    await _dbContext.Set<Preference>().AddRangeAsync(preferences);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
