import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RickDetailsComponent } from './rick-details.component';

describe('RickDetailsComponent', () => {
  let component: RickDetailsComponent;
  let fixture: ComponentFixture<RickDetailsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RickDetailsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RickDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
