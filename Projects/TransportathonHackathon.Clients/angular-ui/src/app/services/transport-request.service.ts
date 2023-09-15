import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { GetByCompanyIdTransportRequestRequest } from '../models/request-models/transport-requests/getByCompanyIdTransportRequestRequest';
import { Observable } from 'rxjs';
import { GetByCompanyIdTransportRequestResponse } from '../models/response-models/transport-requests/getByCompanyIdTransportRequestResponse';
import { GetByCustomerIdTransportRequestRequest } from '../models/request-models/transport-requests/GetByCustomerIdTransportRequestRequest';
import { GetByCustomerIdTransportRequestResponse } from '../models/response-models/transport-requests/GetByCustomerIdTransportRequestResponse';

@Injectable({
  providedIn: 'root',
})
export class TransportRequestService {
  apiUrl = environment.apiUrl + 'transportRequests/';
  constructor(private httpClient: HttpClient) {}

  getListByCompanyId(
    request: GetByCompanyIdTransportRequestRequest
  ): Observable<GetByCompanyIdTransportRequestResponse[]> {
    return this.httpClient.get<GetByCompanyIdTransportRequestResponse[]>(
      this.apiUrl + 'getListByCompanyId/' + request.companyId
    );
  }

  getListByCustomerId(
    request: GetByCustomerIdTransportRequestRequest
  ): Observable<GetByCustomerIdTransportRequestResponse[]> {
    return this.httpClient.get<GetByCustomerIdTransportRequestResponse[]>(
      this.apiUrl + 'getListByCustomerId/' + request.customerId
    );
  }
}
