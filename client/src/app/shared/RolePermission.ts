import { BaseEntity } from "./BaseEntity";

export interface RolePermission extends BaseEntity {
    permissionId: string;
    roleId: string;
}