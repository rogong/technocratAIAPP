import {debounce, TextField } from '@mui/material'
import { useState } from 'react';
import { useAppDispatch, useAppSelector } from '../../app/store/configureStore'
import { setFeedParams } from './feedSlice';


export default function FeedSearch() {
    const {feedParams} = useAppSelector(state => state.feed);
    const [searchTerm, setSearchTerm] = useState(feedParams.searchTerm);
    const dispatch = useAppDispatch();

    const debouncedSearch = debounce((event: any) => {
        dispatch(setFeedParams({searchTerm: event.target.value}))
    }, 1000)

    return (
        <TextField
        label='Serach feeds'
        variant='outlined'
        fullWidth
        value={searchTerm || ''}
        onChange={(event:any) => {
            setSearchTerm(event.target.value);
            debouncedSearch(event);
        }}
         />
    )
}
