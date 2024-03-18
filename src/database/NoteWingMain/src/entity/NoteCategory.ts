import {Column, Entity} from "typeorm"
import {BaseEntity} from "./BaseEntity";

@Entity("NoteCategory")
export class NoteCategory extends BaseEntity{
    @Column({length: 100})
    name: string
}
