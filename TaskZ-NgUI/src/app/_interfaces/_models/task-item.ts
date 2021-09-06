export interface TaskItem{
    id: number;
    parentId: number;
    title: string;
    shortDescription: string;
    dueDate: string;
    minutesSpent: number;
    minutesEstimated: number;
    assignedUserId: number;
    subtaskCount: number;    
}