using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Calyrex : Pokemon
	{
		public override string Name => "Calyrex";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Unnerve() };
		public override Stats BaseStats => new Stats(100, 80, 80, 80, 80, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Pound(), new Moves.Megadrain(), new Moves.Confusion(), new Moves.Growth() },
			[8] = new List<Move>() { new Moves.Lifedew() },
			[16] = new List<Move>() { new Moves.Gigadrain() },
			[24] = new List<Move>() { new Moves.Psyshock() },
			[32] = new List<Move>() { new Moves.Helpinghand() },
			[40] = new List<Move>() { new Moves.Aromatherapy() },
			[48] = new List<Move>() { new Moves.Energyball() },
			[56] = new List<Move>() { new Moves.Psychic() },
			[64] = new List<Move>() { new Moves.Leechseed() },
			[72] = new List<Move>() { new Moves.Healpulse() },
			[80] = new List<Move>() { new Moves.Solarbeam() },
			[88] = new List<Move>() { new Moves.Futuresight() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Allyswitch(), new Moves.Batonpass(), new Moves.Bulletseed(), new Moves.Calmmind(), new Moves.Drainingkiss(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Futuresight(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyterrain(), new Moves.Guardswap(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Imprison(), new Moves.Leafstorm(), new Moves.Lightscreen(), new Moves.Magicalleaf(), new Moves.Magicroom(), new Moves.Metronome(), new Moves.Payday(), new Moves.Pollenpuff(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicterrain(), new Moves.Psyshock(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Solarblade(), new Moves.Speedswap(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Triattack(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
		public override int Weight => 77;
		public override int ExpYield => 250;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 3,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}