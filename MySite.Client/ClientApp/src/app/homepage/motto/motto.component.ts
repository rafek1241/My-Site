import { Component, OnInit } from "@angular/core";
import { MottoService } from "../../api/motto.service";
import { Observable } from "rxjs";
import { Motto } from "../../models/motto";

@Component({
  selector: "app-motto",
  templateUrl: "./motto.component.html",
  styleUrls: ["./motto.component.scss"]
})
export class MottoComponent implements OnInit {
  public currentMotto: Motto;

  constructor(private mottoService: MottoService) {}

  ngOnInit(): void {
    this.mottoService.mottoList$.subscribe(p => {
      const activeMottoes = p.filter(w => w.active === true);
      const randomMottoNumber = Math.floor(
        Math.random() * activeMottoes.length
      );
      this.currentMotto = activeMottoes[randomMottoNumber];
    });
  }
}
