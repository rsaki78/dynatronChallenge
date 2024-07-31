export interface Customer {
  id: number;
  firstName: string;
  lastName: string;
  email: string;
  createdDate: Date;
  lastUpdatedDate: Date;
  isActive: boolean;
  isEdit: boolean;
}
