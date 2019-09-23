import { Injectable } from '@angular/core';
import { CanDeactivate } from '@angular/router';
import { MemberEditComponent } from '../member/member-edit/member-edit.component';

@Injectable()
export class PreventUnsavedChangesGuard implements CanDeactivate<MemberEditComponent> {
  constructor() {}

  canDeactivate(component: MemberEditComponent) {
    if(component.editForm.dirty){
      return confirm('Are you sure you want to lose your changes?');
    }
    return true;
  }
}
