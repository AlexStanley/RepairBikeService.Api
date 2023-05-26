import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { RepairRequestService } from '../repair-request.service';

@Component({
  selector: 'app-repair-request-form',
  templateUrl: './repair-request-form.component.html',
  styleUrls: ['./repair-request-form.component.css'],
})
export class RepairRequestFormComponent {
  repairForm = this.formBuilder.group({
    name: ['', Validators.required],
    email: ['', [Validators.required, Validators.email]],
    description: ['', [Validators.required]],
  });

  isFormSubmitted = false;

  constructor(
    private formBuilder: FormBuilder,
    private repairRequestService: RepairRequestService
  ) {}

  submitForm() {
    this.repairRequestService
      .submitRepairRequest(this.repairForm.value)
      .subscribe({
        next: () => {
          this.isFormSubmitted = true;
          this.repairForm.reset();
        },
        error: () => {
          alert(`An error occurred while submitting the repair request.`);
        },
      });
  }
}
