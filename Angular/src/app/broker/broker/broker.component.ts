import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BrokerService } from 'src/app/services/broker.service';
import { Broker } from 'src/app/shared/broker';

@Component({
  selector: 'app-broker',
  templateUrl: './broker.component.html',
  styleUrls: ['./broker.component.scss']
})
export class BrokerComponent implements OnInit {
  brokers: Broker[] = [];
  dataSource = this.brokers;

  constructor(private brokerService:BrokerService, private router:Router) {}

  ngOnInit(): void {
      this.GetBrokers();
  }

  GetBrokers() {
    this.brokerService.GetAllBrokers().subscribe((result => {
      let brokerList: any[] = result;
      brokerList.forEach((element) => {
        this.brokers.push(element);
      })
    }))
  }

}
