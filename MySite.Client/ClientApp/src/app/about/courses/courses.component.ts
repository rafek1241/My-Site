import { Component, OnInit } from "@angular/core";
import { Observable } from "rxjs";
import { Course } from "../../models/course";
import { CourseService } from "../../api/course.service";

@Component({
  selector: "app-courses",
  templateUrl: "./courses.component.html",
  styleUrls: ["./courses.component.scss"]
})
export class CoursesComponent implements OnInit {
  courses$: Observable<Course[]>;

  constructor(private courseService: CourseService) {}

  ngOnInit() {
    this.courses$ = this.courseService.courses$;
  }
}
