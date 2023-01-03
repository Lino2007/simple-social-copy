import { ApiEntity } from "./BaseEntity";

export interface RolePermission extends ApiEntity {
    permissionId: string;
    roleId: string;
}