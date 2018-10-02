import { Component, OnInit, ViewEncapsulation } from "@angular/core";
import { CertificateService } from "../../api/certificate.service";
import { Observable } from "rxjs";
import { Certificate } from "../../models/certificate";

@Component({
  selector: "app-certificates",
  templateUrl: "./certificates.component.html",
  styleUrls: ["./certificates.component.scss"],
  encapsulation: ViewEncapsulation.None
})
export class CertificatesComponent implements OnInit {
  certificates$: Observable<Certificate[]>;

  constructor(private certificateService: CertificateService) {}

  ngOnInit() {
    this.certificates$ = this.certificateService.certificates$;
  }
}
