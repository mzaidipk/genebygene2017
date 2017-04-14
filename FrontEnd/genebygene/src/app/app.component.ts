import { Component, trigger, state, style, animate, transition, ElementRef, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  host: {
    '(document:click)': 'onClick($event)',
  },
  animations: [
    trigger('menuAnimate', [
      state('inactive', style({
        height: '0px',
        display: 'none',
        overflow: 'hidden'
      })),
      state('active', style({
        height: '*',
        display: 'block',
        overflow: 'hidden'
      })),
      transition('inactive <=> active', [
        animate('500ms cubic-bezier(0.35, 0, 0.25, 1)')
      ])
    ])
  ]
})
export class AppComponent {
   title = 'app works!';
  sysAdminExpanded: boolean = false;

  navState: string = 'inactive';
  constructor(private _eref: ElementRef) { }


  onClick(event) {
    var target = event.target;
    if (this.navState == 'active' && !target.closest("#primaryNavigationMenu")) {
      this.toggleNavMenu();
    }
 
    if (!target.closest("#primaryNavigationMenu") || (!target.classList.contains('submenu') && (target.href !== "undefined" || target.href != ""))) {
      this.closeAllDropDowns();
    }
 
  }


  toggleNavMenu(): void {
    if (this.navState == 'active') {
      this.navState = 'inactive';
    }
    else {
      this.navState = 'active';
    }
  }

  closeAllDropDowns() {
    for (var prop in this.dropdownStates) {
      this.dropdownStates[prop] = "inactive";
    }
  }

  dropdownStates: any = {};
  toggleDropdown(dropdownKey: string) {
    if (this.dropdownStates[dropdownKey] == "active") {
      this.dropdownStates[dropdownKey] = "inactive";
    }
    else {
      this.closeAllDropDowns();
      this.dropdownStates[dropdownKey] = "active";
    }
  }
}
