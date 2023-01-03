import { ApiEntity } from "./BaseEntity";

export interface Comment extends ApiEntity {
    content: string;
    authorId?: string;
    postId?: string;
    editable?: boolean;
}