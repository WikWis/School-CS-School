using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4 {
	class Student : Person {
		private int id;

		public IList<FinalGrade> Grades { get; set; }

		public int Semester { get; set; }
		public int Group { get; set; }

		public int IndexId {
			get { return id; }
			set { id = value; }
		}

		public string Specialization { get; set; }

		public double AverageGrades { get; }

		public Student(string firstName, string lastName, DateTime dateOfBirth,
					   string specialization, int group, int semester) : base(firstName, lastName, dateOfBirth) {
			this.Specialization = specialization;
			this.Group = group;
			this.Semester = semester;
			this.Grades = new List<FinalGrade>();
		}

		public override string ToString() {
			string napis = base.ToString();

			napis += $", id: {this.IndexId}";
			napis += $", Semester: {this.Semester}";
			napis += $", Group: {this.Group}";
			napis += $", Specialization: {this.Specialization}";
			napis += $", AverageGrades: {this.AverageGrades}";

			napis += $", Grades:\n";
			this.Grades.ToList().ForEach(grade => napis += grade + "\n");

			return napis;
		}

	}
}
