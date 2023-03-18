using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gardevoir : Pokemon
	{
		public override string Name => "Gardevoir";
		public override List<Ability> AvailableAbilities => new() {new Synchronize(), new Trace() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Telepathy() };
		public override Stats BaseStats => new Stats(68, 65, 65, 125, 115, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Dazzlinggleam() },
			[1] = new List<Move>() { new Dazzlinggleam(), new Moonblast(), new Mistyterrain(), new Healingwish(), new Charm(), new Growl(), new Disarmingvoice(), new Doubleteam(), new Confusion() },
			[9] = new List<Move>() { new Hypnosis() },
			[12] = new List<Move>() { new Drainingkiss() },
			[15] = new List<Move>() { new Teleport() },
			[18] = new List<Move>() { new Psybeam() },
			[23] = new List<Move>() { new Lifedew() },
			[28] = new List<Move>() { new Wish() },
			[35] = new List<Move>() { new Calmmind() },
			[42] = new List<Move>() { new Psychic() },
			[49] = new List<Move>() { new Healpulse() },
			[56] = new List<Move>() { new Dreameater() },
			[63] = new List<Move>() { new Futuresight() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Bodyslam(), new Calmmind(), new Chargebeam(), new Charm(), new Dazzlinggleam(), new Doubleteam(), new Drainingkiss(), new Dreameater(), new Encore(), new Endure(), new Energyball(), new Expandingforce(), new Facade(), new Firepunch(), new Flash(), new Fling(), new Focusblast(), new Futuresight(), new Gigaimpact(), new Grassknot(), new Guardswap(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icepunch(), new Icywind(), new Imprison(), new Lightscreen(), new Magicalleaf(), new Magicroom(), new Megakick(), new Megapunch(), new Mistyexplosion(), new Mistyterrain(), new Mysticalfire(), new Powerswap(), new Protect(), new Psychic(), new Psychicterrain(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Shadowball(), new Shockwave(), new Skillswap(), new Sleeptalk(), new Snore(), new Storedpower(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Taunt(), new Thief(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Torment(), new Trick(), new Trickroom(), new Tripleaxel(), new Willowisp(), new Wonderroom(), new Zenheadbutt() };
		public override int Weight => 484;
		public override int ExpYield => 259;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}