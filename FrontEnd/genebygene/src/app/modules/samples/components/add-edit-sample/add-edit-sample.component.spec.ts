import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddEditSampleComponent } from './add-edit-sample.component';

describe('AddEditSampleComponent', () => {
  let component: AddEditSampleComponent;
  let fixture: ComponentFixture<AddEditSampleComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddEditSampleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddEditSampleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
