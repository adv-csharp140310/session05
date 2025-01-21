using session05.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.Model;

public class Blog
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }

    [UIControl(typeof(ComboBox), typeof(UserDataProvider))]
    public int UserId { get; set; }
    [NoUI]
    public User User { get; set; }


}


public class UserDataProvider : IDataProvider
{
    public IEnumerable<object> GetData()
    {
        using var db = new AppDbBContext();
        return db.Users.Select(u => new ComboBoxItem
        {
            Value = u.Id,
            Display = u.User_name
        }).ToList();
    }
}