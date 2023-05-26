import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class RepairRequestService {
  constructor(private http: HttpClient) {}

  submitRepairRequest(repairRequest: any) {
    return this.http.post(
      'https://localhost:7101/api/repairrequest',
      repairRequest
    );
  }
}
