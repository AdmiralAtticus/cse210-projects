using System.Data.SqlTypes;
using System.Text;

public class ReportGenerator
{
    public string GenerateReport(UserProfile profile, ActivityLog log, PointsManager pm)
    {
        var sb = new StringBuilder();

        sb.AppendLine($"User: {profile.Name}");
        sb.AppendLine($"Total Points Earned: {pm.TotalPoints}");
        sb.AppendLine($"Calories Burned: {log.GetTotalCalories()}");

        sb.AppendLine("\nGoals:");
        foreach (var g in profile.Goals)
                sb.AppendLine($"- {g.Name} (Completed: {g.IsCompleted})");


        return sb.ToString();
    }
}