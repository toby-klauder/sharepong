# sharepong
shared pong with artists. 

//test ball script 
void Start () {
	
		rigid2D = this.gameObject.GetComponent<Rigidbody2D>();

	
		int rand = Random.Range(1,4);


		if(rand == 1){
			spawnDir = new Vector2(1,1);
		} else if(rand == 2){
			spawnDir = new Vector2(1,-1);
		} else if(rand == 3){
			spawnDir = new Vector2(-1,-1);
		} else if(rand == 4){
			spawnDir = new Vector2(-1,1);
		}

		rigid2D.velocity = (spawnDir*speed);

	}
