using System;

class Program
{
    static void Main(string[] args)
    {
        var user = new UserProfile("Jack", 185);


        var weightGoal = new WeightGoal("Cut to 180", "Track loss in lbs.", 200, 180);
        var stepsGoal = new StepsGoal("10k steps", "Daily step target", 100, 10000);
        var WorkoutGoal = new WorkoutGoal("Workout 45min", "Daily exercise", 200, 45);

        user.AddGoal(weightGoal);
        user.AddGoal(stepsGoal);
        user.AddGoal(workoutGoal);

        // Log daily activity
        var log = new ActivityLog();
        log.AddActivity(new RunningActivity(20));
        log.AddActivity(new LiftingActivity(15));

        // Update goal progression
        weightGoal.LogWeight(184.5);
        stepsGoal.LogSteps(10500);
        workoutGoal.LogWorkout(35);

        // Process goals + points
        var pm = new PointsManager();
        pm.ProcessGoals(user.Goals);

        // Report
        var reportGen = new ReportGenerator();
        var report = reportGen.GenerateReport(user, log, pm);

        Console.WriteLine(report);
    }
}