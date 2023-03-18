using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cresselia : Pokemon
	{
		public override string Name => "Cresselia";
		public override List<Ability> AvailableAbilities => new() {new Levitate() };
		public override Stats BaseStats => new Stats(120, 70, 120, 75, 130, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Confusion(), new Doubleteam() },
			[6] = new List<Move>() { new Mist() },
			[12] = new List<Move>() { new Aurorabeam() },
			[18] = new List<Move>() { new Psybeam() },
			[24] = new List<Move>() { new Psychoshift() },
			[30] = new List<Move>() { new Slash() },
			[36] = new List<Move>() { new Psychocut() },
			[42] = new List<Move>() { new Moonlight() },
			[48] = new List<Move>() { new Safeguard() },
			[54] = new List<Move>() { new Psychic() },
			[60] = new List<Move>() { new Moonblast() },
			[66] = new List<Move>() { new Futuresight() },
			[72] = new List<Move>() { new Lunardance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Bodyslam(), new Calmmind(), new Chargebeam(), new Doubleteam(), new Dreameater(), new Endure(), new Energyball(), new Expandingforce(), new Facade(), new Flash(), new Futuresight(), new Gigaimpact(), new Grassknot(), new Guardswap(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icywind(), new Lightscreen(), new Magicroom(), new Powerswap(), new Protect(), new Psychic(), new Psychocut(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Solarbeam(), new Storedpower(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thunderwave(), new Trick(), new Trickroom(), new Zenheadbutt() };
		public override int Weight => 856;
		public override int ExpYield => 300;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 3,
			[Stat.Speed] = 0
		};
	}
}