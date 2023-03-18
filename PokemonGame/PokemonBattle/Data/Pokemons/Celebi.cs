using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Celebi : Pokemon
	{
		public override string Name => "Celebi";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Naturalcure() };
		public override Stats BaseStats => new Stats(100, 100, 100, 100, 100, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Confusion(), new Moves.Healbell() },
			[10] = new List<Move>() { new Moves.Magicalleaf() },
			[20] = new List<Move>() { new Moves.Batonpass() },
			[30] = new List<Move>() { new Moves.Ancientpower() },
			[40] = new List<Move>() { new Moves.Lifedew() },
			[50] = new List<Move>() { new Moves.Leechseed() },
			[60] = new List<Move>() { new Moves.Recover() },
			[70] = new List<Move>() { new Moves.Futuresight() },
			[80] = new List<Move>() { new Moves.Healingwish() },
			[90] = new List<Move>() { new Moves.Leafstorm() },
			[100] = new List<Move>() { new Moves.Perishsong() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Allyswitch(), new Moves.Aurasphere(), new Moves.Batonpass(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Cut(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Dualwingbeat(), new Moves.Earthpower(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Flash(), new Moves.Fling(), new Moves.Futuresight(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Imprison(), new Moves.Leafblade(), new Moves.Leafstorm(), new Moves.Lightscreen(), new Moves.Magicalleaf(), new Moves.Magicroom(), new Moves.Metronome(), new Moves.Nastyplot(), new Moves.Pollenpuff(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicterrain(), new Moves.Psychocut(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Seedbomb(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Solarblade(), new Moves.Stealthrock(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Waterpulse(), new Moves.Weatherball(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
		public override int Weight => 50;
		public override int ExpYield => 300;
		public override int CatchRate => 45;
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