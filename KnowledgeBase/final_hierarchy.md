        ┌──────────────────┐
        │   Workout (abs)  │
        ├──────────────────┤
        │ - Date           │
        │ - DurationMin    │
        │ - Calories       │
        ├──────────────────┤
        │ + CalculateCal() │
        │ + GetSummary()   │
        └───────┬──────────┘
                │
 ┌──────────────┴───────────────┐
 │                                │
 │                                │
┌────────────────────┐   ┌────────────────────┐
│ StrengthWorkout     │   │ CardioWorkout      │
├────────────────────┤   ├────────────────────┤
│ - MuscleGroup       │   │ - ActivityType     │
│ - Sets              │   │ - DistanceMiles    │
│ - Reps              │   ├────────────────────┤
├────────────────────┤   │ + CalculateCal()   │
│ + CalculateCal()    │   │ + GetSummary()     │
│ + GetSummary()      │   └────────────────────┘
└────────────────────┘



        ┌─────────────────┐
        │   Goal (abs)    │
        ├─────────────────┤
        │ - Description   │
        │ - IsComplete    │
        ├─────────────────┤
        │ + UpdateProg()  │
        │ + GetStatus()   │
        └──────┬──────────┘
               │
 ┌─────────────┴─────────────────┐
 │                               │
┌──────────────────────┐   ┌──────────────────────┐
│ WeightLossGoal        │   │ StrengthGoal         │
├──────────────────────┤   ├──────────────────────┤
│ - StartWeight         │   │ - TargetExercise     │
│ - TargetWeight        │   │ - TargetReps         │
├──────────────────────┤   ├──────────────────────┤
│ + UpdateProg()        │   │ + UpdateProg()        │
└──────────────────────┘   └──────────────────────┘
