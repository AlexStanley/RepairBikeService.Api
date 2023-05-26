import { Component } from '@angular/core';
import { RepairRequestService } from '../repair-request.service';

@Component({
  selector: 'app-repair-request-form',
  templateUrl: './repair-request-form.component.html',
  styleUrls: ['./repair-request-form.component.css'],
})
export class RepairRequestFormComponent {
  name: string | any;
  email: string | any;
  description: string | any;

  constructor(private repairRequestService: RepairRequestService) {}

  submitForm() {
    const repairRequest = {
      name: this.name,
      email: this.email,
      description: this.description,
    };

    this.repairRequestService.submitRepairRequest(repairRequest).subscribe({
      next: () => {
        alert('Repair request submitted successfully.');
      },
      error: () => {
        alert(`An error occurred while submitting the repair request.`);
      },
    });
  }
}
