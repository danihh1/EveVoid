import { Component, OnInit, Inject } from '@angular/core';
import { MAT_SNACK_BAR_DATA, MatSnackBarRef } from '@angular/material/snack-bar';

@Component({
  selector: 'app-delete-sigs-snack',
  templateUrl: './delete-sigs-snack.component.html',
  styleUrls: ['./delete-sigs-snack.component.css']
})
export class DeleteSigsSnackComponent implements OnInit {

  constructor(private snackBarRef: MatSnackBarRef<DeleteSigsSnackComponent>,
    @Inject(MAT_SNACK_BAR_DATA) public data: any) { }

  ngOnInit(): void {
  }

  confirmDelete() {
    this.data.signatures = this.data.signatures.filter(x =>
      this.data.pastedData.findIndex(p => p.signatureId === x.signatureId) > 0 || x.signatureId === '???');
    this.snackBarRef.dismissWithAction();
  }
}
