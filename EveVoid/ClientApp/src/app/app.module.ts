import { AlphabetDirective } from './directives/alphabet-only.directive';
import { environment } from './../environments/environment';
import { FlexLayoutModule } from '@angular/flex-layout';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule, LOCALE_ID } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { CallbackComponent } from './callback/callback.component';
import { CallbackEsiComponent } from './callback-esi/callback-esi.component';
import { MainCharacterComponent } from './main-character/main-character.component';
import { EsiCharacterComponent } from './esi-character/esi-character.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatListModule } from '@angular/material/list';
import {MatIconModule} from '@angular/material/icon';
import {MatMenuModule} from '@angular/material/menu';
import {MatToolbarModule} from '@angular/material/toolbar';
import { LoginComponent } from './login/login.component';
import { PerfectScrollbarModule } from 'ngx-perfect-scrollbar';
import { MapComponent } from './map/map.component';
import {MatSnackBarModule} from '@angular/material/snack-bar';
import { MapHomeComponent } from './map-home/map-home.component';
import { SolarSystemComponent } from './solar-system/solar-system.component';
import {MatButtonToggleModule} from '@angular/material/button-toggle';
import { MatTooltipModule} from '@angular/material/tooltip';
import { MatBadgeModule } from '@angular/material/badge';
import { NgxGraphModule} from '@swimlane/ngx-graph';
import { MapGraphComponent } from './map-graph/map-graph.component';
import { MatDialogModule } from '@angular/material/dialog';
import { MatSelectModule } from '@angular/material/select';
import { MatAutocompleteModule } from '@angular/material/autocomplete';
import { SignatureDialogComponent } from './signature-dialog/signature-dialog.component';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MomentModule } from 'ngx-moment';
import { MatChipsModule } from '@angular/material/chips';
import { MatTableModule } from '@angular/material/table';
import { DeleteSigsSnackComponent } from './delete-sigs-snack/delete-sigs-snack.component';
import { MapTabLayoutComponent } from './map-tab-layout/map-tab-layout.component';
import { TabDialogComponent } from './tab-dialog/tab-dialog.component';
import { MatSortModule } from '@angular/material/sort';
import { NumberAbbreviatePipe } from './pipes/number-abbreviate.pipe';
import { MatInputModule } from '@angular/material/input';
import { MatRadioModule } from '@angular/material/radio';
import { AutoJumpDialogComponent } from './auto-jump-dialog/auto-jump-dialog.component';
import { DurationLeftPipe } from './pipes/duration-left.pipe';
import { MatPaginatorModule } from '@angular/material/paginator';


const routes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'callback', component: CallbackComponent },
  { path: 'callback-esi', component: CallbackEsiComponent },
  { path: 'login', component: LoginComponent },
  {
    path: 'map',
    component: HomeComponent,
    children: [
      {
        path: '',
        component: MapComponent,
      },
      {
        path: ':id',
        component: MapComponent,
      },
    ],
  },
];

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    CallbackComponent,
    CallbackEsiComponent,
    MainCharacterComponent,
    EsiCharacterComponent,
    LoginComponent,
    MapComponent,
    MapHomeComponent,
    SolarSystemComponent,
    MapGraphComponent,
    SignatureDialogComponent,
    DeleteSigsSnackComponent,
    MapTabLayoutComponent,
    TabDialogComponent,
    NumberAbbreviatePipe,
    AlphabetDirective,
    AutoJumpDialogComponent,
    DurationLeftPipe,
  ],
  imports: [
    MatBadgeModule,
    MatCardModule,
    MatButtonModule,
    FlexLayoutModule,
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    MatButtonModule,
    MatIconModule,
    MatListModule,
    MatMenuModule,
    MatToolbarModule,
    MatSidenavModule,
    MatSnackBarModule,
    MatButtonToggleModule,
    MatSelectModule,
    MatTooltipModule,
    MatDialogModule,
    MatFormFieldModule,
    FormsModule,
    ReactiveFormsModule,
    MatAutocompleteModule,
    PerfectScrollbarModule,
    NgxGraphModule,
    MatTableModule,
    MatSortModule,
    MomentModule,
    MatChipsModule,
    MatInputModule,
    MatRadioModule,
    RouterModule.forRoot(routes),
    BrowserAnimationsModule,
    MatPaginatorModule
  ],
  providers: [NumberAbbreviatePipe, AlphabetDirective, DurationLeftPipe],
  bootstrap: [AppComponent]
})
export class AppModule { }
