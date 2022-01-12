import { useRef } from 'react';
import { history } from '../..';
import './search.css';

export default function BasicSearch() {
  const searchInputRef = useRef<any>(null);

  const search = (e: any) => {
    e.preventDefault();
    const term = searchInputRef.current.value;

    if (!term) return;
    console.log(term)
    history.push(`/result/${encodeURI(term)}`);
  };

  return (
    <>
  <div className='mt'>
    <h1>What a</h1>
  </div>
    <div id="cover">
    
  <form>
    <div className="tb">
      <div className="td">
        <input type="text" id="si"  ref={searchInputRef} placeholder="Enter keywords" 
        required  className='input-text'/>
        </div>
      <div className="td" id="s-cover">
        <button onClick={search} id="sb">
          <div id="s-circle"></div>
          <span></span>
        </button>
      </div>
    </div>
  </form>
</div>

    
    </>
  );
}
