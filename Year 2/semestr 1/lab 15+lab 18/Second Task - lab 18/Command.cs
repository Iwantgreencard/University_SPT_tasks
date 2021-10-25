using System;
using System.Collections.Generic;
using System.Text;
using Second_task;

namespace Second_Task___lab_18
{
    class Command : Person
    {
        private int game_score;
        private int goal_score;

        public Command()
        {

        }
        public Command(int height, int weight, DateTime date_of_birth, string last_name, int game_score, int goal_score)
        {
            this.height = height;
            this.weight = weight;
            this.date_of_birth = date_of_birth;
            this.last_name = last_name;
            this.game_score = game_score;
            this.goal_score = goal_score;
        }
        public int Games
        {
            get { return game_score; }
        }
        public int Goal_score
        {
            get { return goal_score; }
        }
        public void set_game_score(int game_score)
        {
            this.game_score = game_score;
        }
        public void set_goal_core(int goal_score)
        {
            this.goal_score = goal_score;
        }
        public override void show_person()
        {
            base.show_person();
            Console.WriteLine($"     | Кількість проведених ігор: {this.game_score}");
            Console.WriteLine($"     | Кількість забитих голів: {this.goal_score}");
        }
        public override void show_person(bool show_picture)
        {
            base.show_person(true);
            Console.WriteLine($"     | Кількість проведених ігор: {this.game_score}");
            Console.WriteLine($"     | Кількість забитих голів: {this.goal_score}");
        }
        public double average_goals()
        {
            return(Convert.ToDouble(this.goal_score)/ Convert.ToDouble(this.game_score));
        }
    }
}
